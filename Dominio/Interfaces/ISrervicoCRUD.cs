using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface ISrervicoCRUD<TEntity>
        where TEntity : class
    {
        IEnumerable<TEntity> Listagem();

        void Cadastrar(TEntity categoria);

        TEntity CarregarRegistro(int id);

        void Excluir(int id);
    }
}
