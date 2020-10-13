using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Interfaces
{
    public interface IRepositorio<TEntity>
        where TEntity : class
    {
        void Create(TEntity Entity);
        TEntity Read(int id);
        void Delete(int id);
        IEnumerable<TEntity> Read();
    }
}
