using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Factory_Method
{
    public class FactoryPessoa
    {
        public Pessoa getPessoa(string nome, string tipo)
        {
            if (tipo.Equals("PF"))
            {
                return new PessoaFisica(nome);

            }
            else if (tipo.Equals("PJ"))
            {
                return new PessoaJuridica(nome);
            }
            else
            {
                return null;
            }

        }
	

	
    }
}
