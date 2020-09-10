using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Senha { get; set; }
    }
}
