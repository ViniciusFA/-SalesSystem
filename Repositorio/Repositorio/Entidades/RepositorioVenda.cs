using Microsoft.EntityFrameworkCore;
using Dominio.Repositorio;
using SistemaVenda.Dominio.Entidades;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Entidades
{
    public class RepositorioVenda: Repositorio<Venda>, IRepositorioVenda
    {
        public RepositorioVenda(ApplicationDbContext dbContext) : base(dbContext)
        {
        } 

        public override void Delete(int id)
        {
            //antes precisamos excluir os id's de venda que estão na tabela VendaProdutos
            var listaProdutos = DbSetContext.Include(x => x.Produtos)
                .Where(y => y.Codigo == id)
                .AsNoTracking()
                .ToList();           

            VendaProdutos vendaProdutos;
            foreach (var item in listaProdutos[0].Produtos)
            {
                vendaProdutos = new VendaProdutos()
                {
                    CodigoVenda = id,
                    CodigoProduto = item.CodigoProduto
                };

                //delete dos produtos da venda
                DbSet<VendaProdutos> DbSetAux = Db.Set<VendaProdutos>();
                DbSetAux.Attach(vendaProdutos);
                DbSetAux.Remove(vendaProdutos);
                Db.SaveChanges();
            }

            //delete da venda
            base.Delete(id);
        }
    }
}
