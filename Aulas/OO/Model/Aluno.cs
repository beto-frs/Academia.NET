using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO.Model
{
    class Aluno : Pessoa
    {
        public override void FazTarefa()
        {
            Console.WriteLine("Faz Exercício");
        }
    }
}
