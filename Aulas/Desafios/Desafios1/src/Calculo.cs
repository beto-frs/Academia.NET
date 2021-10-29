using System;

namespace Desafio1
{
    public class Calculo
    {
        public double inicial { get; set; }
        public int intervalo { get; set; }
        public double result = 0;
        public double aux = 0;
        public int loops { get; set; }
        

        public double Cond(int n)
        {
            result = inicial / (n + 1);
            if (n % 2 == 0)
            {
                Console.Write("+ ( {0} / {1} = {2} ) ", inicial, n + 1, Math.Round(result, 2));
                result = aux + result;
            }
            else
            {
                Console.Write("- ( {0} / {1} = {2} ) ", inicial, n + 1, Math.Round(result, 2));
                result = aux - result;
            }
            return result;
        }
    }
}
