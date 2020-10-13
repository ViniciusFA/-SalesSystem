using System.Collections.Generic;
using System.Linq;
using Aplicacao.Serviço.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class CategoriaController : Controller
    {
        readonly IServicoAplicacaoCategoria ServicoAplicacaoCategoria;

        public CategoriaController (IServicoAplicacaoCategoria servicoAplicacaoCategoria)
        {
            ServicoAplicacaoCategoria = servicoAplicacaoCategoria;
        }

        public IActionResult Index()
        {  
            return View(ServicoAplicacaoCategoria.Listagem());
        }


        //[HttpGet]
        //public IActionResult Cadastro(int? id)
        //{
        //    CategoriaViewModel viewModel = new CategoriaViewModel();

        //    if (id.HasValue)
        //    {
        //        var categoriaDb = mContext.Categoria.Where(x => x.Codigo == id).SingleOrDefault();

        //        viewModel.Codigo = categoriaDb.Codigo;
        //        viewModel.Descricao = categoriaDb.Descricao;
        //    }

        //    return View(viewModel);
        //}

        //[HttpPost]
        //public IActionResult Cadastro(CategoriaViewModel viewModel)
        //{
        //    //ModelState check the model's DataAnnotations    
        //    if (ModelState.IsValid)
        //    {
        //        Categoria categoria = new Categoria
        //        {
        //            Codigo = viewModel.Codigo,
        //            Descricao = viewModel.Descricao
        //        };

        //        if (viewModel.Codigo != null)
        //            mContext.Entry(categoria).State = EntityState.Modified;
        //        else
        //            mContext.Categoria.Add(categoria);

        //        mContext.SaveChanges();
        //    }
        //    else
        //        return View(viewModel);

        //    return RedirectToAction("Index");

        //}

        //[HttpGet]
        //public IActionResult Excluir(int? id)
        //{
        //    Categoria resultCategoria = null;

        //    if (id.HasValue)
        //    {
        //        resultCategoria = mContext.Categoria.Where(x => x.Codigo == id).SingleOrDefault();
        //        mContext.Categoria.Remove(resultCategoria);
        //        mContext.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View();
        //}

    }
}