using System;
using PDFeTXT.Models;


namespace PDFeTXT.Source
{
    class Program
    {
        static void Main(string[] args)
        {
            Processos execute = new();
            execute.ReadText();
        }
    }
}
