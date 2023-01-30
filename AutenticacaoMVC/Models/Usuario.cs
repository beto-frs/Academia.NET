using System.ComponentModel.DataAnnotations;

namespace AutenticacaoMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Required(ErrorMessage ="Erro")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Erro")]
        public string  Senha { get; set; }

        public string Token { get; set; }
    }
}
