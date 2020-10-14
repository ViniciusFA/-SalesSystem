using Aplicacao.Serviço.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class Produtoontroller : Controller
    {
        readonly IServicoAplicacaoProduto ServicoAplicacaoProduto;
        readonly IServicoAplicacaoCategoria ServicoAplicacaoCategoria;

        public Produtoontroller(IServicoAplicacaoProduto servicoAplicacaoProduto,
            IServicoAplicacaoCategoria servicoAplicacaoCategoria)
        {
            ServicoAplicacaoProduto = servicoAplicacaoProduto;
            ServicoAplicacaoCategoria = servicoAplicacaoCategoria;
        }

        public IActionResult Index()
        {  
            return View(ServicoAplicacaoProduto.Listagem());
        }
        
        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            ProdutoViewModel viewModel = new ProdutoViewModel();

            if (id != null)
            {
                viewModel = ServicoAplicacaoProduto.CarregarRegistro(id.Value);
            }

            viewModel.ListaCategorias = ServicoAplicacaoCategoria.ListaCategoriasDropDownList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
            {
                ServicoAplicacaoProduto.Cadastrar(viewModel);
            }               
            else
            {
                viewModel.ListaCategorias = ServicoAplicacaoCategoria.ListaCategoriasDropDownList();
                return View(viewModel);
            }               

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            ServicoAplicacaoProduto.Excluir(id.Value);
            return RedirectToAction("Index");
        }
    }
}