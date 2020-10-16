using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Helpers;
using SistemaVenda.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Aplicacao.Serviço.Interfaces;

namespace SistemaVenda.Controllers
{
    public class LoginController : Controller
    {
        readonly IServicoAplicacaoUsuario ServicoAplicacaoUsuario;
        protected IHttpContextAccessor httpContextAcessor;

        public LoginController(IServicoAplicacaoUsuario servicoAplicacaoUsuario, 
            IHttpContextAccessor HttpContext)
        {
            ServicoAplicacaoUsuario = servicoAplicacaoUsuario;
            httpContextAcessor = HttpContext;
        }

        public IActionResult Index(int? id)
        {
            if(id !=null )
            {
                if (id == 0)
                {
                    httpContextAcessor.HttpContext.Session.Clear();
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            ViewData["ErrorLogin"] = string.Empty;

            if (ModelState.IsValid)
            {
               var senhaCriptogafada = Criptografia.GetMd5Hash(model.Senha);

                //login : vini@gmail.com 
                //senha : 123456
                bool loginValido = ServicoAplicacaoUsuario.ValidarLogin(model.Email, senhaCriptogafada);
                var usuario = ServicoAplicacaoUsuario.RetornarDadosUsuario(model.Email, senhaCriptogafada);

                if (loginValido)
                {
                    //colocar os dados do usuário na sessão
                    httpContextAcessor.HttpContext.Session.SetString(Sessao.NOME_USUARIO, usuario.Nome);
                    httpContextAcessor.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, usuario.Email);
                    httpContextAcessor.HttpContext.Session.SetInt32(Sessao.CODIGO_USUARIO, usuario.Codigo.Value);
                    httpContextAcessor.HttpContext.Session.SetInt32(Sessao.LOGADO, 1);

                    return RedirectToAction("Index" , "Home");
                }
                else
                {
                    ViewData["ErrorLogin"] = "Email ou Senha incorretos.";
                }
            }
            
            return View(model);
        }
    }
}