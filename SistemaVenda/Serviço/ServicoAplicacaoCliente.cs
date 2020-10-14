using Aplicacao.Serviço.Interfaces;
using Dominio.Interfaces;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models.ViewModel;
using System.Collections.Generic;

namespace Aplicacao.Serviço
{
    public class ServicoAplicacaoCliente : IServicoAplicacaoCliente
    {
        private readonly IServicoCliente ServicoCliente;

        public ServicoAplicacaoCliente(IServicoCliente servicoCliente)
        {
            ServicoCliente = servicoCliente;
        }

        public IEnumerable<ClienteViewModel> Listagem()
        {
            var lista = ServicoCliente.Listagem();
            List<ClienteViewModel> listaViewModel = new List<ClienteViewModel>();

            foreach (var item in lista)
            {
                ClienteViewModel viewModel = new ClienteViewModel
                {
                    Codigo = item.Codigo,
                    Nome = item.Nome,
                    Email = item.Email,
                    Celular = item.Celular,
                    CNPJ_CPF = item.CNPJ_CPF
                };

                listaViewModel.Add(viewModel);
            }

            return listaViewModel;
        }

        public void Cadastrar(ClienteViewModel clienteViewModel)
        {
            Cliente cliente = new Cliente()
            {
                Codigo = clienteViewModel.Codigo,
                Nome = clienteViewModel.Nome,
                Email = clienteViewModel.Email,
                Celular = clienteViewModel.Celular,
                CNPJ_CPF = clienteViewModel.CNPJ_CPF
            }; 

            ServicoCliente.Cadastrar(cliente);
        }

        public ClienteViewModel CarregarRegistro(int codigoCliente)
        {
            var registro = ServicoCliente.CarregarRegistro(codigoCliente);

            ClienteViewModel clienteViewModel = new ClienteViewModel
            {
                Codigo = registro.Codigo,
                Nome = registro.Nome,
                Email = registro.Email,
                Celular = registro.Celular,
                CNPJ_CPF = registro.CNPJ_CPF
            };

            return clienteViewModel;
        }

        public void Excluir(int id)
        {
            ServicoCliente.Excluir(id);
        }     
    }
}
