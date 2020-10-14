using Aplicacao.Serviço.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Models.ViewModel;

namespace SistemaVenda.Controllers
{
    public class Clienteontroller : Controller
    {
        readonly IServicoAplicacaoCliente ServicoAplicacaoCliente;

        public Clienteontroller(IServicoAplicacaoCliente servicoAplicacaoCliente)
        {
            ServicoAplicacaoCliente = servicoAplicacaoCliente;
        }

        public IActionResult Index()
        {  
            return View(ServicoAplicacaoCliente.Listagem());
        }
        
        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            ClienteViewModel viewModel = ServicoAplicacaoCliente.CarregarRegistro(id.Value);           
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
                ServicoAplicacaoCliente.Cadastrar(viewModel);
            else
                return View(viewModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            ServicoAplicacaoCliente.Excluir(id.Value);
            return RedirectToAction("Index");
        }
    }
}