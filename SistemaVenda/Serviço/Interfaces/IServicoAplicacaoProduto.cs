using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Models.ViewModel;
using System.Collections.Generic;

namespace Aplicacao.Serviço.Interfaces
{
    public interface IServicoAplicacaoProduto
    {
        IEnumerable<SelectListItem> ListaProdutosDropDownList();
        ProdutoViewModel CarregarRegistro(int codigoProduto);

        IEnumerable<ProdutoViewModel> Listagem();

        void Cadastrar(ProdutoViewModel produtoViewModel);

        void Excluir(int id);
    }
}
