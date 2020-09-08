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
    public class ClienteController : Controller
    {
        protected ApplicationDbContext mContext;

        public ClienteController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> listaCategoria = mContext.Cliente.ToList();
            return View(listaCategoria);
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            ClienteViewModel viewModel = new ClienteViewModel();

            if (id.HasValue)
            {
                var clienteDb = mContext.Cliente.Where(x => x.Codigo == id).SingleOrDefault();

                viewModel.Codigo = clienteDb.Codigo;
                viewModel.Nome = clienteDb.Nome;
                viewModel.Email = clienteDb.Email;
                viewModel.CNPJ_CPF = clienteDb.CNPJ_CPF;
                viewModel.Celular = clienteDb.Celular;
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteViewModel viewModel)
        {
            //ModelState check the model's DataAnnotations    
            if (ModelState.IsValid)
            {
                Cliente cliente = new Cliente
                {
                    Codigo = viewModel.Codigo,
                    Nome = viewModel.Nome,
                    CNPJ_CPF = viewModel.CNPJ_CPF,
                    Celular = viewModel.Celular,
                    Email = viewModel.Email                    
                };

                if (viewModel.Codigo != null)
                    mContext.Entry(cliente).State = EntityState.Modified;
                else
                    mContext.Cliente.Add(cliente);

                mContext.SaveChanges();
            }
            else
                return View(viewModel);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            Cliente resultCliente = null;

            if (id.HasValue)
            {
                resultCliente = mContext.Cliente.Where(x => x.Codigo == id).SingleOrDefault();
                mContext.Cliente.Remove(resultCliente);
                mContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}