using System.ComponentModel.DataAnnotations;

namespace AulaMVCEF.Models
{
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome da Pessoa")]
        [StringLength(100, MinimumLength = 8)]
        public string Nome { get; set; }

        public virtual ICollection<EmailModel> Emails { get; set; }
    }
}
