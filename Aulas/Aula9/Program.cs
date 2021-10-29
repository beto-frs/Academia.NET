using System;
using static System.Console;

namespace Aula9
{
    class Program
    {

        static void Main(string[] args)
        {
            //Ex1();
            Ex2();

        }

        //FIBONNACCI 
        /*int n, i, ant=1, antant=0, fib;

        fib = ant + antant;
        antant = ant;
        ant = fib*/

        static void Ex1()
        {
            /*Fazer um algoritmo que leia dez números inteiros armazenando-os 
             * em um vetor e armazene em um novo vetor primeiramente todos os 
             * números pares lidos e após todos os ímpares. Exemplo:
             * a. lê: |7|40|3|9|21|0|63|31|7|22|
             * b. escreve: |40|0|22|7|3|9|21|63|31|7| */


            int[] par = new int[10], impar = new int[10];
            int valor, countPar = 0, countImpar = 0;
            for (int i = 0; i < 10; i++)
            {
                Random rand = new();
                Write("Digite um o {0}º número: ", i + 1);
                valor = rand.Next(1,10);
                if (valor % 2 == 0)
                {
                    par[countPar] = valor;
                    countPar += 1;
                }
                else
                {
                    impar[countImpar] = valor;
                    countImpar += 1;
                }
            }
            WriteLine("\nDe todos os números digitados, {0} são pares e {1} são ímpares!\n", countPar, countImpar);
            for (int i = 0; i < countPar; i++)
            {
                Write(" {0} |", par[i]);
            }
            for (int i = 0; i < countImpar; i++)
            {
                Write(" {0} |", impar[i]);
            }
            ReadLine();
        }

        static void Ex2()
        {
            /* Escreva um algoritmo que leia um vetor inteiro de 20 posições.
             * Crie um segundo vetor, substituindo os valores nulos por 2.
             * Mostre os vetores lidos e o vetor resultado.*/

            int[] vetor = new int[20];
            int[] segundoVetor = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Random rand = new();
                vetor[i] = rand.Next(-1, 2);
                Write("\nDigite um número: {0}", vetor[i]);
                if (vetor[i] == 0)
                {
                    segundoVetor[i] = 2;
                }
                else
                {
                    segundoVetor[i] = vetor[i];
                }
            }
            Write("\n======================================================================\n");
            Write("\nVetor Inicial:\n");
            foreach (int v1 in vetor)
            {
                Write("{0} | ", v1);
            }
            Write("\n\nVetor Resultado:\n");
            foreach (int v2 in segundoVetor)
            {
                Write("{0} | ", v2);
            }












        }




    }
}
