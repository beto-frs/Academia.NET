using System;
using System.Collections.Generic;
using static System.Console;

namespace Listas
{
    
    class Program
    {
        static List<Pessoa> pessoas;

        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa(40, "Ricardo"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));
            pessoas.Add(new Pessoa(25, "Ana"));

            foreach (Pessoa p in pessoas)
            {
                WriteLine($" {p._nome} tem {p._idade} anos de idade.");
            }
            ListainserirItemNaPosicao();
            ListaNaoOrdenada();
            WriteLine();
            ListaOrdenadaPorNome();
            WriteLine();
            ListaOrdenadaPorIdade();
            
        }

        static void ListaNaoOrdenada()
        {
            
            pessoas.ForEach(delegate (Pessoa p) 
            {
                WriteLine($"{p._nome} tem {p._idade} anos de idade.");
            });
        }

        static void ListaOrdenadaPorNome()
        {
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
                {
                    return p1._nome.CompareTo(p2._nome);
                });
            
            pessoas.ForEach(delegate (Pessoa p)
            {
                WriteLine($"{p._nome} tem {p._idade} anos de idade.");
            });

        }

        static void ListaOrdenadaPorIdade()
        {
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1._idade.CompareTo(p2._idade);
            });

            pessoas.ForEach(delegate (Pessoa p)
            {
                WriteLine($"{p._nome} tem {p._idade} anos de idade.");
            });

        }

        static void ListainserirItemNaPosicao()
        {
            pessoas.Insert(1, new Pessoa() { 
                _nome = "Bob Dylan", _idade = 78 
            });
            pessoas.Insert(3, new Pessoa() { 
                _nome = "Jimmy Page", _idade = 81
            });
        }

        static void ListaConverterParaArray()
        {
            Pessoa[] ListaArray = pessoas.ToArray();
            foreach (Pessoa p in ListaArray)
            {
                WriteLine($"{p._idade} {p._nome}");
            }
        }

        static void ListaLocalizaPessoaMaisJovem()
        {
            List<Pessoa> jovem = pessoas.FindAll(delegate (Pessoa p) 
            { 
                return p._idade < 45; 
            });

            jovem.ForEach(delegate (Pessoa p)
            {
                WriteLine($"{p._idade} {p._idade}");
            });
        }

        static void Dict()
        {
            IDictionary
        }



    }
}
