using System;
using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVenda.Dominio.Entidades
{
    public class Venda
    {
        [Key]
        public int? Codigo { get; set; }

        public DateTime Data { get; set; }

        [ForeignKey("Cliente")]
        public int CodigoCliente { get; set; }

        public Cliente Cliente { get; set; }

        public decimal Total { get; set; }

        public ICollection<VendaProdutos> Produtos { get; set; }
    }
}
