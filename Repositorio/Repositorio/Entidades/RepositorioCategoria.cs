using Dominio.Repositorio;
using SistemaVenda.Dominio.Entidades;
using Repositorio.Contexto;

namespace Repositorio.Entidades
{
    public class RepositorioCliente : Repositorio<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(ApplicationDbContext dbContext) : base(dbContext)
        {
        } 
    }
}
