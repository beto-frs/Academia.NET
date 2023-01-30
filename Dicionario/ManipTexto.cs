using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace Dicionario
{
    public class ManipTexto
    {
        string caminho { get; set; }
        string line { get; set; }

        public void ManipulandoTexto()
        {
            Write("Digite o nome do arquivo: ");
            caminho = @$"D:\{ReadLine()}.txt";
            StreamWriter sw = new(caminho,true,Encoding.UTF8);

            try
            {
                sw.WriteLine("Olá mundo!!!");
            }
            catch
            {
                WriteLine("Erro na criação do arquivo");
            }
            finally
            {
                sw.Close();
                WriteLine("Finalizando...");
            }
            

        }
        public void CaptTextNumb()
        {
            StreamReader sr = new StreamReader(@$"D:\Teste.txt");
            line = sr.ReadLine();
            Regex regex = new Regex("[0-9]+");
            Match match = regex.Match(line);

            while (line != null)
            {

                if (match.Success)
                    Console.WriteLine("Number found: " + match.Value);
            }
            sr.Close();
        }
    }
}
