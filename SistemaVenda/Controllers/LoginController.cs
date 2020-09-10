using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Helpers;
using SistemaVenda.Models.ViewModel;
using Microsoft.AspNetCore.Http;

namespace SistemaVenda.Controllers
{
    public class LoginController : Controller
    {
        protected ApplicationDbContext context;
        protected IHttpContextAccessor httpContext;

        public LoginController(ApplicationDbContext Context, IHttpContextAccessor HttpContext)
        {
            context = Context;
            httpContext = HttpContext;
        }

        public IActionResult Index(int? id)
        {
            if(id !=null && id == 0)
            {
                httpContext.HttpContext.Session.Clear();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            ViewData["ErrorLogin"] = string.Empty;

            if (ModelState.IsValid)
            {
               var senha = Criptografia.GetMd5Hash(loginViewModel.Senha);

                var resultDataBase = context.Usuario.Where(x => x.Email == loginViewModel.Email 
                                                             && x.Senha == senha).SingleOrDefault();
                if(resultDataBase != null)
                {
                    //colocar os dados do usuário na sessão
                    httpContext.HttpContext.Session.SetString(Sessao.NOME_USUARIO, resultDataBase.Nome);
                    httpContext.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, resultDataBase.Email);
                    httpContext.HttpContext.Session.SetInt32(Sessao.CODIGO_USUARIO, resultDataBase.Codigo.Value);
                    httpContext.HttpContext.Session.SetInt32(Sessao.LOGADO, 1);

                    return RedirectToAction("Index" , "Home");
                }
                else
                {
                    ViewData["ErrorLogin"] = "Email ou Senha incorretos.";
                }
            }
            
            return View(loginViewModel);
        }
    }
}