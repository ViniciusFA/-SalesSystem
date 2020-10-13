using Microsoft.EntityFrameworkCore;
using Dominio.Repositorio;
using SistemaVenda.Dominio.Entidades;
using Repositorio.Contexto;

namespace Repositorio.Entidades
{
    public class RepositorioCategoria : Repositorio<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(ApplicationDbContext dbContext) : base(dbContext)
        {
        } 
    }
}
