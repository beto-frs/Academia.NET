using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome)
        {
            this.Nome = nome;
            this.Tipo = $"PJ";
        }
    }
}
