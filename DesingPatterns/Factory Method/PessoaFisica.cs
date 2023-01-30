using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome)
        {
            this.Nome = nome;
            this.Tipo = $"PF";
        }
    }
}
