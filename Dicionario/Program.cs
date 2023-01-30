using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipTexto manipTexto = new();
            //manipTexto.ManipulandoTexto();
            manipTexto.CaptTextNumb();

        }


        static void Dicionario()
        {
            IDictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "Maria");
            dic1.Add(2, "Paulo");
            dic1.Add(3, "`Pedro");

            Dictionary<int, string> dic2 = new Dictionary<int, string>()
            {
                {0,"Banana"},
                {1, "Laranja" },
                {2, "Manga" },
                {3, "Abacate" },
                {4, "Maçã" }
            };

            foreach (KeyValuePair<int, string> item in dic2)
            {
                WriteLine($"{item.Key} | {item.Value}");
            }

            WriteLine(dic2[2]);
            WriteLine(dic2[0]);

            WriteLine();
            WriteLine(dic2.ContainsKey(1));
            WriteLine(dic2.ContainsKey(6));

            WriteLine(dic2.ContainsValue("Banana"));

            if (dic2.TryGetValue(4, out string resultado))
            {
                WriteLine(dic2.Count);
                WriteLine(resultado);
            }
            else
            {
                WriteLine("Não foi possível achar a chave específica.");
            }

            WriteLine(dic2.Values.Count(x => x == "Banana"));
        }




    }
}
