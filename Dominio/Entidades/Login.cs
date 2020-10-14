using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Dominio.Entidades
{
    public class Login : EntityBase
    {
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
