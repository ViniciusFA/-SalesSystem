using SistemaVenda.Entidades;
using SistemaVenda.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Serviço.Interfaces
{
    public interface IServicoAplicacaoCategoria
    {
        CategoriaViewModel CarregarRegistro(int codigoCategoria);

        IEnumerable<CategoriaViewModel> Listagem();

        void Cadastrar(CategoriaViewModel categoriaViewModel);

        void Excluir(int id);
    }
}
