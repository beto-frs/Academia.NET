using System;
using static System.Console;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            //double i = 0,soma = 0, imp=0, cont=0;
            /*while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i>10);


            while (i < 100)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }


            while (i<=100)
            {
                soma = soma + i;
                i++;
            }
            Console.WriteLine(soma);

            while (i<100)
            {
                if (i%2!=0)
                {
                    imp = imp + i;
                    cont = cont + 1;
                }
                i++;
            }

            Console.WriteLine(Math.Round(imp/cont));
            Console.ReadLine();

            bool resp = true;
            int n1 = 0;


            while (resp)
            {
                Console.WriteLine("Digite um numero: ");
                n1 = int.Parse(Console.ReadLine());

                if (n1 == 0)
                {
                    resp = false;
                }

            }

            int valor = 0;
            do
            {
                Console.WriteLine("Digite um valor:");
                valor = int.Parse(Console.ReadLine());

                if (valor%2==0)
                {
                    Console.WriteLine("o valor digitado é par.");
                }
                else
                {
                    Console.WriteLine("o valor digitado é impar.");
                }


            } while (valor !=0);*/


            /*
             * 
             * 
            3 - Existem 3 números de 4 dígitos (entre 1000 e 9999) que obedecem à 
            seguinte característica: 
            se dividirmos o número em dois números de dois dígitos, 
            um composto pela dezena e pela unidade, e outro pelo milhar e pela centena, 
            somarmos estes dois novos números gerando um terceiro, 
            o quadrado deste terceiro número é exatamente o número original de quatro dígitos. 
            Por exemplo:
            2025 dividindo: 20 e 25 e 
            somando temos 45 e 45² = 2025.
            Escreva um programa para calcular todos os números que obedecem a esta característica.

            DICA IMPORTANTE: LEMBREM-SE DA MINHA EXPLICAÇÃO SOBRE RESTO DA DIVISÃO!
            resto da divisão de um número por 5 = n%5 - irá variar de 0 até 4.
            resto da divisão de um número por 4 = n%4 - irá variar de 0 até 3.
            resto da divisão de um número por 3 = n%3 - irá variar de 0 até 2.
            resto da divisão de um número por 2 = n%2 - irá variar entre 0 e 1.
            */




            /*int i, m, d, soma, p;
            for (i = 1000; i <= 9999; i++)
            {
                m = i / 100;
                d = i % 100;
                soma = d + m;
                p = soma * soma;
                if (p == i)
                {
                    Console.WriteLine(i + " Satisfaz as regras. ");
                }
            }*/

            /* Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
                soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1 / n
                n = 10
                s = 1 + 1/2+ 1/3+ 1/4 + 1/5 + 1/6 + 1/7 + 1/8 + 1/9 +1/10*/

            /*int n, i;
            double s=0,a;
            WriteLine("Digite um numero:");
            n = int.Parse(ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = i;
                s += 1 / i;
            }
            WriteLine("O resultado é: {0}", s);*/




            /*
            * Faça um programa que leia um número n e imprima se ele é primo ou não. 
            * (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)
            * */









            /*Os dois primeiros números da sequência de Fibonacci são 0 e 1.
             * Qualquer outro número desta sequência pode ser calculado pela soma dos dois imediatamente anteriores: 
             * F0 = 0; F1 = 1; Fn = Fn−1 + Fn−2
             * Os primeiros números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
             * Fazer um algoritmo que leia um número N e mostre os primeiros N números da série de Fibonacci.*/








            /*int numero;
            WriteLine("Digite um numero:");
            double resultado = int.Parse(ReadLine());

            for (int i = 0; i < resultado; i++)
            {
                numero = i + (1 / i);
            }

            */



            /*   Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte 
                 soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1 / n 
          n = 10
          s = 1/1 + 1/2+ 1/3+ 1/4 + 1/5 + 1/6 + 1/7 + 1/8 + 1/9 +1/10
           */
            int n, i;
            double s = 0, a;
            Console.WriteLine("Digite um numero :");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                //a = i;
                s += 1 / (double)i;
            }
            Console.WriteLine("O resultado da soma: " + s);
        }


    }

}

