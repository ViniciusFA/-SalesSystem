using Aplicacao.Serviço.Interfaces;
using Dominio.Interfaces;
using Newtonsoft.Json;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models.ViewModel;
using System.Collections.Generic;

namespace Aplicacao.Serviço
{
    public class ServicoAplicacaoVenda : IServicoAplicacaoVenda
    {
        private readonly IServicoVenda ServicoVenda;

        public ServicoAplicacaoVenda(IServicoVenda servicoVenda)
        {
            ServicoVenda = servicoVenda;
        }

        public IEnumerable<VendaViewModel> Listagem()
        {
            var lista = ServicoVenda.Listagem();
            List<VendaViewModel> listaViewModel = new List<VendaViewModel>();

            foreach (var item in lista)
            {
                VendaViewModel viewModel = new VendaViewModel
                {
                    Codigo = item.Codigo,
                    Data = item.Data,
                    CodigoCliente = item.CodigoCliente,
                    Total = item.Total
                };

                listaViewModel.Add(viewModel);
            }

            return listaViewModel;
        }

        public void Cadastrar(VendaViewModel vendaViewModel)
        {
            Venda venda = new Venda()
            {
                Codigo = vendaViewModel.Codigo,
                Data = vendaViewModel.Data.Value,
                CodigoCliente = vendaViewModel.CodigoCliente.Value,
                Total = vendaViewModel.Total,
                Produtos = JsonConvert.DeserializeObject<ICollection<VendaProdutos>>(vendaViewModel.JsonProdutos)
            };

            ServicoVenda.Cadastrar(venda);
        }

        public VendaViewModel CarregarRegistro(int codigoCliente)
        {
            var registro = ServicoVenda.CarregarRegistro(codigoCliente);

            VendaViewModel vendaViewModel = new VendaViewModel
            {
                Codigo = registro.Codigo,
                Data = registro.Data,
                CodigoCliente = registro.CodigoCliente,
                Total = registro.Total
            };

            return vendaViewModel;
        }

        public void Excluir(int id)
        {
            ServicoVenda.Excluir(id);
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            List<GraficoViewModel> lista = new List<GraficoViewModel>();

            var listaAux = ServicoVenda.ListaGtafico();

            foreach (var item in listaAux)
            {
                GraficoViewModel grafico = new GraficoViewModel()
                {
                    CodigoProduto = item.CodigoProduto,
                    Descricao = item.Descricao,
                    TotalVendido = item.TotalVendido
                };

                lista.Add(grafico);
            }

           return lista;
        }
    }
}
