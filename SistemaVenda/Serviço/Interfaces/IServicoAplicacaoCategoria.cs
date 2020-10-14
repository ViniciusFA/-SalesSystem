using Microsoft.AspNetCore.Mvc.Rendering;
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
        IEnumerable<SelectListItem> ListaCategoriasDropDownList();
        CategoriaViewModel CarregarRegistro(int codigoCategoria);

        IEnumerable<CategoriaViewModel> Listagem();

        void Cadastrar(CategoriaViewModel categoriaViewModel);

        void Excluir(int id);
    }
}
