using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using SistemaVenda.Dominio.Entidades;

namespace Repositorio
{
    public abstract class Repositorio<TEntity> : DbContext, IRepositorio<TEntity>
        where TEntity : class, new()
    {
        DbContext db;
        DbSet<TEntity> DbSetContext;

        public Repositorio(DbContext dbContext)
        {
            db = dbContext;
            DbSetContext = db.Set<TEntity>();
        }

        public void Create(TEntity Entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
