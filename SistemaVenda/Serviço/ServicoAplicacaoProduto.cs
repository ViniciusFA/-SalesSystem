using Aplicacao.Serviço.Interfaces;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models.ViewModel;
using System.Collections.Generic;

namespace Aplicacao.Serviço
{
    public class ServicoAplicacaoProduto : IServicoAplicacaoProduto
    {
        private readonly IServicoProduto ServicoProduto;

        public ServicoAplicacaoProduto(IServicoProduto servicoProduto)
        {
            ServicoProduto = servicoProduto;
        }

        public IEnumerable<ProdutoViewModel> Listagem()
        {
            var lista = ServicoProduto.Listagem();
            List<ProdutoViewModel> listaViewModel = new List<ProdutoViewModel>();

            foreach (var item in lista)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao,
                    Quantidade = item.Quantidade,
                    Valor = item.Valor,
                    CodigoCategoria = item.CodigoCategoria,
                    DescricaoCategoria = item.Categoria.Descricao
                };

                listaViewModel.Add(viewModel);
            }

            return listaViewModel;
        }

        public void Cadastrar(ProdutoViewModel produtoViewModel)
        {
            Produto produto = new Produto()
            {
                Codigo = produtoViewModel.Codigo,
                Descricao = produtoViewModel.Descricao,
                Quantidade = produtoViewModel.Quantidade,
                Valor = produtoViewModel.Valor.Value,
                CodigoCategoria = produtoViewModel.CodigoCategoria.Value
            };

            ServicoProduto.Cadastrar(produto);
        }

        public ProdutoViewModel CarregarRegistro(int codigoProduto)
        {
            var registro = ServicoProduto.CarregarRegistro(codigoProduto);

            ProdutoViewModel produtoViewModel = new ProdutoViewModel
            {
                Codigo = registro.Codigo,
                Descricao = registro.Descricao,
                Quantidade = registro.Quantidade,
                Valor = registro.Valor,
                CodigoCategoria = registro.CodigoCategoria
            };

            return produtoViewModel;
        }

        public void Excluir(int id)
        {
            ServicoProduto.Excluir(id);
        }

        public IEnumerable<SelectListItem> ListaProdutosDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();

            var lista = this.Listagem();

            foreach (var item in lista)
            {
                SelectListItem produto = new SelectListItem()
                {
                    Value = item.Codigo.ToString(),
                    Text = item.Descricao
                };
                retorno.Add(produto);
            }

            return retorno;
        }
    }
}
