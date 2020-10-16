using Dominio.Repositorio;
using SistemaVenda.Dominio.Entidades;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Entidades
{
    public class RepositorioUsuario : Repositorio<Usuario>, IRepositorioUsuario
    {
        public RepositorioUsuario(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool ValidarLogin(string email, string senha)
        {
            var usuario = DbSetContext.Where(x => x.Email == email.ToUpper() && x.Senha == senha.ToUpper())
                                      .FirstOrDefault();

            return usuario == null ? false : true ;
        }
    }
}
