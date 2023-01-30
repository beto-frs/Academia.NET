using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO.Model
{
    class Professor : Pessoa
    {
        public override void FazTarefa()
        {
            Console.WriteLine("Corrige Exercício");
        }
    }
}
