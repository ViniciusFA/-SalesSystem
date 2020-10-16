using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;
using Dominio.Repositorio;
using Dominio.Interfaces;
using SistemaVenda.Dominio.DTO;

namespace Dominio.Serviços
{
    public class ServicoVenda : IServicoVenda
    {
        IRepositorioVenda RepositorioVenda;
        IRepositorioVendaProdutos RepositorioVendaProdutos;

        public ServicoVenda(IRepositorioVenda repositorioVenda, 
            IRepositorioVendaProdutos repositorioVendaProdutos)
        {
            RepositorioVenda = repositorioVenda;
            RepositorioVendaProdutos = repositorioVendaProdutos;
        }

        public void Cadastrar(Venda venda)
        {
            RepositorioVenda.Create(venda);
        }
        
        public Venda CarregarRegistro(int id)
        {
            return RepositorioVenda.Read(id);
        }

        public void Excluir(int id)
        {
            RepositorioVenda.Delete(id);
        }

        public IEnumerable<Venda> Listagem()
        {
            return RepositorioVenda.Read();
        }

        public IEnumerable<GraficoViewModel> ListaGtafico()
        {
            return RepositorioVendaProdutos.ListaGtafico();
        }
    }
}
