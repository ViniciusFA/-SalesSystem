using Aplicacao.Serviço.Interfaces;
using Dominio.Serviços;
using SistemaVenda.Dominio.Entidades;
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

        public void Cadastrar(CategoriaViewModel categoriaViewModel)
        {
            Categoria categoria = new Categoria()
            {
                Codigo = categoriaViewModel.Codigo,
                Descricao = categoriaViewModel.Descricao,
            }; 

            ServicoCategoria.Cadastrar(categoria);
        }

        public CategoriaViewModel CarregarRegistro(int codigoCategoria)
        {
            var registro = ServicoCategoria.CarregarRegistro(codigoCategoria);

            CategoriaViewModel categoriaViewModel = new CategoriaViewModel
            {
                Codigo = registro.Codigo,
                Descricao = registro.Descricao
            };

            return categoriaViewModel;
        }

        public void Excluir(int id)
        {
            ServicoCategoria.Excluir(id);
        }     
    }
}
