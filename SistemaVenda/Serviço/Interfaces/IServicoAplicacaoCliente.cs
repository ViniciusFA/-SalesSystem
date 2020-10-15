using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Models.ViewModel;
using System.Collections.Generic;

namespace Aplicacao.Serviço.Interfaces
{
    public interface IServicoAplicacaoCliente
    {
        IEnumerable<SelectListItem> ListaClientesDropDownList();

        ClienteViewModel CarregarRegistro(int codigoCliente);

        IEnumerable<ClienteViewModel> Listagem();

        void Cadastrar(ClienteViewModel clienteViewModel);

        void Excluir(int id);
    }
}
