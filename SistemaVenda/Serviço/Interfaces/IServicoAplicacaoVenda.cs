using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Models.ViewModel;
using System.Collections.Generic;

namespace Aplicacao.Serviço.Interfaces
{
    public interface IServicoAplicacaoVenda
    {
        VendaViewModel CarregarRegistro(int vendaCliente);

        IEnumerable<VendaViewModel> Listagem();

        void Cadastrar(VendaViewModel vendaViewModel);

        void Excluir(int id);

        IEnumerable<GraficoViewModel> ListaGrafico();
    }
}
