using Aplicacao.Serviço.Interfaces;
using Dominio.Serviços;
using SistemaVenda.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Serviço
{
    public class ServicoAplicacaoCategoria : IServicoAplicacaoCategoria
    {
        private readonly IServicoCategoria ServicoCategoria;

        public ServicoAplicacaoCategoria(IServicoCategoria servicoCategoria)
        {
            ServicoCategoria = servicoCategoria;
        }

        public IEnumerable<CategoriaViewModel> Listagem()
        {
            var lista = ServicoCategoria.Listagem();
            List<CategoriaViewModel> listaViewModel = new List<CategoriaViewModel>();

            foreach (var item in lista)
            {
                CategoriaViewModel viewModel = new CategoriaViewModel
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao
                };

                listaViewModel.Add(viewModel);
            }

            return listaViewModel;
        }
    }
}
