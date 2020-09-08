using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class CategoriaController : Controller
    {
        protected ApplicationDbContext mContext;

        public CategoriaController (ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> listaCategoria = mContext.Categoria.ToList();
            return View(listaCategoria);
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            CategoriaViewModel viewModel = new CategoriaViewModel();

            if (id.HasValue)
            {
                var categoriaDb = mContext.Categoria.Where(x => x.Codigo == id).SingleOrDefault();

                viewModel.Codigo = categoriaDb.Codigo;
                viewModel.Descricao = categoriaDb.Descricao;
            }  

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CategoriaViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
            {      
                Categoria categoria = new Categoria
                {
                    Codigo = viewModel.Codigo,
                    Descricao = viewModel.Descricao
                };

                if (viewModel.Codigo != null) 
                    mContext.Entry(categoria).State = EntityState.Modified;
                else
                    mContext.Categoria.Add(categoria);

                mContext.SaveChanges();
            }
            else
                return View(viewModel);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            Categoria resultCategoria = null;

            if (id.HasValue)
            {
                resultCategoria = mContext.Categoria.Where(x => x.Codigo == id).SingleOrDefault();
                mContext.Categoria.Remove(resultCategoria);
                mContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}