using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OO.Model
{
    abstract class Pessoa
    {
        protected string nome { get; set; }
        protected int idade { get; set; }
        protected string cpf { get; set; }



        public void Viver()
        {
            WriteLine("andando...");
        }

        public void Morrer()
        {
            WriteLine("comendo...");
        }

        public abstract void FazTarefa();
      
    }
}
