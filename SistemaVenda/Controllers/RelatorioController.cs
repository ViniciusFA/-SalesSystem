using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class RelatorioController : Controller
    {
        protected ApplicationDbContext mContext;

        public RelatorioController(ApplicationDbContext Context)
        {
            mContext = Context;
        }

        public IActionResult Grafico()
        {
            var lista = mContext.VendaProdutos
                .GroupBy(x => x.CodigoProduto)
                .Select(y => new GraficoViewModel
                {
                    CodigoProduto = y.FirstOrDefault().CodigoProduto,
                    Descricao = y.FirstOrDefault().Produto.Descricao,
                    TotalVendido = y.Sum(x => x.Quantidade)
                }).ToList();

            string valores = string.Empty;
            string labels = string.Empty;
            string cores = string.Empty;

            var random = new Random();
            for (int i = 0; i < lista.Count; i++)
            {
                valores += lista[i].TotalVendido.ToString() + " , ";
                labels += "'" + lista[i].Descricao + "' , ";
                cores += "'" + String.Format("#{0:X6}", random.Next(0x10000000)) + "' , ";
            }

            ViewBag.Valores = valores;
            ViewBag.Labels = labels;
            ViewBag.Cores = cores;

            return View(lista);
           
        }
    }
}