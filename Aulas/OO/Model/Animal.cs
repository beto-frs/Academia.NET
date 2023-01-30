using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OO.Model
{
    public class Animal
    {
        private string _nome { get; set; }
        private string _raca { get; set; }
        //public string raca { get => raca ; set => _raca = value; }

        private string _sexo { get; set; }

        private string _tipo { get; set; }


        
        public Animal(string n, string r, string s, string t) : base()
        {
            _nome = n;
            _raca = r;
            _sexo = s;
            _tipo = t;

        }

        public void EmitirSom(string s)
        {
            WriteLine($"O {_nome} de raça {_raca} emite o som {s}.");
        }

        public void Dormir()
        {
            WriteLine($"O {_nome} está dormindo.");
        }

        public void Caminhar()
        {
            WriteLine($"O {_nome} está caminhando.");
        }

        
    }
}
