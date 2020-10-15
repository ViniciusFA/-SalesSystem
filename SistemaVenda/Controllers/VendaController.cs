using Aplicacao.Serviço.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class VendaController : Controller
    {
        readonly IServicoAplicacaoVenda ServicoAplicacaoVenda;
        readonly IServicoAplicacaoProduto ServicoAplicacaoProduto;
        readonly IServicoAplicacaoCliente ServicoAplicacaoCliente;

        public VendaController(IServicoAplicacaoVenda servicoAplicacaoVenda,
            IServicoAplicacaoProduto servicoAplicacaoProduto,
            IServicoAplicacaoCliente servicoAplicacaoCliente)
        {
            ServicoAplicacaoVenda = servicoAplicacaoVenda;
            ServicoAplicacaoProduto = servicoAplicacaoProduto;
            ServicoAplicacaoCliente = servicoAplicacaoCliente;
        }

        public IActionResult Index()
        {  
            return View(ServicoAplicacaoVenda.Listagem());
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            VendaViewModel viewModel = new VendaViewModel();

            if(id.HasValue)
            {
                viewModel = ServicoAplicacaoVenda.CarregarRegistro(id.Value);
            }

            viewModel.ListaClientes = ServicoAplicacaoCliente.ListaClientesDropDownList();
            viewModel.ListaProdutos = ServicoAplicacaoProduto.ListaProdutosDropDownList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(VendaViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
            {
                ServicoAplicacaoVenda.Cadastrar(viewModel);                
            }                
            else
            {
                viewModel.ListaClientes = ServicoAplicacaoCliente.ListaClientesDropDownList();
                viewModel.ListaProdutos = ServicoAplicacaoProduto.ListaProdutosDropDownList();

                return View(viewModel);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            ServicoAplicacaoVenda.Excluir(id.Value);
            return RedirectToAction("Index");
        }

        [HttpGet("LerValorProduto/{CodigoProduto}")]
        public decimal LerValorProduto(int CodigoProduto)
        {
            return (decimal)ServicoAplicacaoProduto.CarregarRegistro(CodigoProduto).Valor;
        }
    }
}