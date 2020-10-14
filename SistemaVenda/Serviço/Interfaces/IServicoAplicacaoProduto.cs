using SistemaVenda.Entidades;
using SistemaVenda.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Serviço.Interfaces
{
    public interface IServicoAplicacaoProduto
    {
        ProdutoViewModel CarregarRegistro(int codigoProduto);

        IEnumerable<ProdutoViewModel> Listagem();

        void Cadastrar(ProdutoViewModel produtoViewModel);

        void Excluir(int id);
    }
}
