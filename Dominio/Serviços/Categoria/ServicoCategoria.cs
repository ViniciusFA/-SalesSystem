using System;
using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;
using System.Text;
using Dominio.Repositorio;

namespace Dominio.Serviços
{
    public class ServicoCategoria : IServicoCategoria
    {
        IRepositorioCategoria RepositorioCategoria;

        public ServicoCategoria(IRepositorioCategoria repositorioCategoria)
        {
            RepositorioCategoria = repositorioCategoria;
        }

        public void CadastrarCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Categoria CarregarRegistro(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> Listagem()
        {
            return RepositorioCategoria.Read();
        }
    }
}
