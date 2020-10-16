using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Models.ViewModel;
using System.Collections.Generic;

namespace Aplicacao.Serviço.Interfaces
{
    public interface IServicoAplicacaoCategoria
    {
        IEnumerable<SelectListItem> ListaCategoriasDropDownList();
        CategoriaViewModel CarregarRegistro(int codigoCategoria);

        IEnumerable<CategoriaViewModel> Listagem();

        void Cadastrar(CategoriaViewModel categoriaViewModel);

        void Excluir(int id);
    }
}
