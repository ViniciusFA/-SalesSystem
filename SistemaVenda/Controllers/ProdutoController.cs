using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class ProdutoController : Controller
    {
        protected ApplicationDbContext mContext;

        public ProdutoController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Produto> listaProduto = mContext.Produto.Include(x => x.Categoria).ToList();
            return View(listaProduto);
        }

        private IEnumerable<SelectListItem> ListaCategoria()
        {
            List<SelectListItem> lista = new List<SelectListItem>();

            lista.Add(new SelectListItem()
            {
                Value = string.Empty,
                Text = "Selecione"
            });

            foreach (var item in mContext.Categoria.ToList())
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
            ProdutoViewModel viewModel = new ProdutoViewModel();
            viewModel.ListaCategorias = ListaCategoria();

            if (id.HasValue)
            {
                var categoriaDb = mContext.Produto.Where(x => x.Codigo == id).SingleOrDefault();

                viewModel.Codigo = categoriaDb.Codigo;
                viewModel.Descricao = categoriaDb.Descricao;
                viewModel.Quantidade = categoriaDb.Quantidade;
                viewModel.Valor = categoriaDb.Valor;
                viewModel.CodigoCategoria = categoriaDb.CodigoCategoria;
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
            {
                Produto produto = new Produto
                {
                    Codigo = viewModel.Codigo,
                    Descricao = viewModel.Descricao,
                    Quantidade = viewModel.Quantidade,
                    Valor = viewModel.Valor.Value,
                    CodigoCategoria = viewModel.CodigoCategoria.Value
                };

                if (viewModel.Codigo != null)
                    mContext.Entry(produto).State = EntityState.Modified;
                else
                    mContext.Produto.Add(produto);

                mContext.SaveChanges();
            }
            else
            {
                viewModel.ListaCategorias = ListaCategoria();
                return View(viewModel);
            }              

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            Produto resultProduto = null;

            if (id.HasValue)
            {
                resultProduto = mContext.Produto.Where(x => x.Codigo == id).SingleOrDefault();
                mContext.Produto.Remove(resultProduto);
                mContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}