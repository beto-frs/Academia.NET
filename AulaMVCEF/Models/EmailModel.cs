namespace AulaMVCEF.Models
{
    public class EmailModel
    {
        public int id { get; set; }

        public string email { get; set; }

        public virtual PessoaModel pessoa { get; set; }
    }
}
