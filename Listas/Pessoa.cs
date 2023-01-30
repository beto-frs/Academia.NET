using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pessoa
    {
        public string _nome { get; set; }
        public int _idade { get; set; }

        public Pessoa() { }

        public Pessoa(int idade, string nome)
        {
            this._idade = idade;
            this._nome = nome;
        }


    }
}
