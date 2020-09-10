using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class VendaController : Controller
    {
        protected ApplicationDbContext mContext;

        public VendaController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Venda> listaProduto = mContext.Venda.ToList();
            return View(listaProduto);
        }

        private IEnumerable<SelectListItem> ListaCliente()
        {
            List<SelectListItem> lista = new List<SelectListItem>
            {
                new SelectListItem()
                {
                    Value = string.Empty,
                    Text = "Selecione"
                }
            };

            foreach (var item in mContext.Cliente.ToList())
            {
                lista.Add(new SelectListItem()
                {
                    Value = item.Codigo.ToString(),
                    Text = item.Nome.ToString()
                });
            }

            return lista;
        }

        private IEnumerable<SelectListItem> ListaProduto()
        {
            List<SelectListItem> lista = new List<SelectListItem>
            {
                new SelectListItem()
                {
                    Value = string.Empty,
                    Text = "Selecione"
                }
            };

            foreach (var item in mContext.Produto.ToList())
            {
                lista.Add(new SelectListItem()
                {
                    Value = item.Codigo.ToString(),
                    Text = item.Descricao.ToString()
                });
            }

            return lista;
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            VendaViewModel viewModel = new VendaViewModel();
            viewModel.ListaClientes = ListaCliente();
            viewModel.ListaProdutos = ListaProduto();

            if (id.HasValue)
            {
                var categoriaDb = mContext.Venda.Where(x => x.Codigo == id).SingleOrDefault();

                viewModel.Codigo = categoriaDb.Codigo;
                viewModel.Data = categoriaDb.Data;
                viewModel.CodigoCliente = categoriaDb.CodigoCliente;
                viewModel.Total = categoriaDb.Total;
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(VendaViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
            {
                Venda venda = new Venda
                {
                    Codigo = viewModel.Codigo,
                    Data = viewModel.Data.Value,
                    CodigoCliente = viewModel.CodigoCliente.Value,
                    Total = viewModel.Total,
                    Produtos = JsonConvert.DeserializeObject<ICollection<VendaProdutos>>(viewModel.JsonProdutos)
                };

                if (viewModel.Codigo != null)
                    mContext.Entry(venda).State = EntityState.Modified;
                else
                    mContext.Venda.Add(venda);

                mContext.SaveChanges();
            }
            else
            {
                viewModel.ListaClientes = ListaCliente();
                viewModel.ListaProdutos = ListaProduto();
                return View(viewModel);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            Venda resultVenda = null;

            if (id.HasValue)
            {
                resultVenda = mContext.Venda.Where(x => x.Codigo == id).SingleOrDefault();
                mContext.Venda.Remove(resultVenda);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet("LerValorProduto/{CodigoProduto}")]
        public decimal LerValorProduto(int CodigoProduto)
        {
            return mContext.Produto.Where(x => x.Codigo == CodigoProduto).Select(x => x.Valor).SingleOrDefault();
        }
    }
}