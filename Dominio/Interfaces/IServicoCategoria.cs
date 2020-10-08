using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Serviços
{
    public interface IServicoCategoria
    {
        IEnumerable<Categoria> Listagem();

        void CadastrarCategoria(Categoria categoria);

        Categoria CarregarRegistro(int id);

        void Excluir(int id);
    }
}
