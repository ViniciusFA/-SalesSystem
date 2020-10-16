using Aplicacao.Serviço.Interfaces;
using Dominio.Interfaces;
using System.Linq;
using SistemaVenda.Dominio.Entidades;

namespace Aplicacao.Serviço
{
    public class ServicoAplicacaoUsuario : IServicoAplicacaoUsuario
    {
        private readonly IServicoUsuario ServicoUsuario;

        public ServicoAplicacaoUsuario(IServicoUsuario servicoUsuario)
        {
            ServicoUsuario = servicoUsuario;
        }

        public Usuario RetornarDadosUsuario(string email, string senha)
        {
            return ServicoUsuario.Listagem()
                                 .Where(x => x.Email == email && x.Senha == senha)
                                 .FirstOrDefault();
        }

        public bool ValidarLogin(string email, string senha)
        {
            return ServicoUsuario.ValidarLogin(email, senha);
        }
    }
}
