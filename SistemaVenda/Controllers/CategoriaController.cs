using System.Collections.Generic;
using System.Linq;
using Aplicacao.Serviço.Interfaces;
using Microsoft.AspNetCore.Mvc;
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
        
        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            CategoriaViewModel viewModel = ServicoAplicacaoCategoria.CarregarRegistro(id.Value);           
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CategoriaViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
                ServicoAplicacaoCategoria.Cadastrar(viewModel);
            else
                return View(viewModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            ServicoAplicacaoCategoria.Excluir(id.Value);
            return RedirectToAction("Index");
        }
    }
}