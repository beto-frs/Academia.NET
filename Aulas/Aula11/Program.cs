using System;
using System.Linq;
using static System.Console;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };            
            WriteLine(integers.Max());
            WriteLine(integers.Min());
        }
    }
}
