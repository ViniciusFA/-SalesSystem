using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models.ViewModel
{
    public class CategoriaViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }
    }
}
