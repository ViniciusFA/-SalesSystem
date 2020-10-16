using Dominio.Repositorio;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Entidades
{
    public class RepositorioVendaProdutos : IRepositorioVendaProdutos
    {
        protected ApplicationDbContext DbSetContext;
        public RepositorioVendaProdutos(ApplicationDbContext mContext)
        {
            DbSetContext = mContext;
        }

        public IEnumerable<GraficoViewModel> ListaGtafico()
        {
            var lista = DbSetContext.VendaProdutos
                .Include(x => x.Produto)
                 .GroupBy(x => x.CodigoProduto)
                 .Select(y => new GraficoViewModel
                 {
                     CodigoProduto = y.FirstOrDefault().CodigoProduto,
                     Descricao = y.FirstOrDefault().Produto.Descricao,
                     TotalVendido = y.Sum(x => x.Quantidade)
                 }).ToList();

            return lista;
        }
    }
}
