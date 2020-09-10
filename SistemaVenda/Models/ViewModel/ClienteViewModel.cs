using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models.ViewModel
{
    public class ClienteViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string CNPJ_CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Celular { get; set; }
    }
}
