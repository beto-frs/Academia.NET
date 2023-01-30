

namespace Infra
{
    public class PessoaModel : IPessoaModel
    {
        public string _id { get; set; }
        public string _nome { get; set; }
        public string _telefone { get; set; }
        public string _cidade { get; set; }
        public string _rg { get; set; }
        public string _cpf { get; set; }
        public string _matricula { get; set; }
        public string _codigoCurso { get; set; }
        public string _nomeCurso { get; set; }

        public PessoaModel pessoaModel()
        {
            return this;
        }
    }
}
