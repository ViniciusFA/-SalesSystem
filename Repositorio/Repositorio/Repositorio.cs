using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using SistemaVenda.Dominio.Entidades;

namespace Repositorio
{
    public abstract class Repositorio<TEntity> : DbContext, IRepositorio<TEntity>
        where TEntity : EntityBase, new()
    {
        protected DbContext Db;
        protected DbSet<TEntity> DbSetContext;

        public Repositorio(DbContext dbContext)
        {
            Db = dbContext;
            DbSetContext = Db.Set<TEntity>();
        }

        public void Create(TEntity Entity)
        {
           if(Entity.Codigo == null)
                DbSetContext.Add(Entity);
            else
                Db.Entry(Entity).State = EntityState.Modified;

            Db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var cliente = new TEntity { Codigo = id };
            DbSetContext.Attach(cliente);
            DbSetContext.Remove(cliente);
            Db.SaveChanges();
        }

        public TEntity Read(int id)
        {
            return DbSetContext.Where(x => x.Codigo == id).FirstOrDefault();
        }

        public virtual IEnumerable<TEntity> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
