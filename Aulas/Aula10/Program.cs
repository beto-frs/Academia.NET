using System;
using static System.Console;

namespace Aula10
{
    class Program
    {
        static int qtd = 10;
        static int[] valores, indicePar, indiceImpar, valorPar, valorImpar;

        static void Main(string[] args)
        {
            Vetor();
            Inverter(valores);
            VetorIndice(valores);
            VetorElemento(valores);
        }

        static void Vetor()
        {
            valores = new int[qtd];
            Random rand = new Random();
            for (int i = 0; i < qtd; i++)
            {
                valores[i] = rand.Next(1, 10);
                Write(" {0} |", valores[i]);
            }
            Write(" => Vetor Principal\n\n");
        }

        static void Inverter(int[] vetor)
        {
            int[] inverso = new int[qtd];
            int indice = 0;
            for (int i = qtd; i > 0; i--)
            {
                inverso[indice] = valores[(i-1)];
                Write(" {0} |", inverso[indice]);
                indice++;
            }
            Write(" => Vetor Invertido\n\n");
        }

        static void VetorIndice(int[] vetor)
        {
            indicePar = new int[qtd];
            indiceImpar = new int[qtd];
            int par = 0, impar = 0;
            for (int i = 0; i < qtd; i++)
            {
                if (i%2==0)
                {
                    indicePar[par] = valores[i];
                    par++;
                }
                else
                {
                    indiceImpar[impar] = valores[i];
                    impar++;
                }
            }
            ExibirVetores(indicePar, indiceImpar, "vetores");
        }

        static void VetorElemento(int[] vetor)
        {
            valorPar = new int[qtd];
            valorImpar = new int[qtd];
            int par = 0, impar = 0;
            for (int i = 0; i < qtd; i++)
            {
                if (valores[i]%2==0)
                {
                    valorPar[par] = valores[i];
                    par++;
                }
                else
                {
                    valorImpar[impar] = valores[i];
                    impar++;
                }
            }
            ExibirVetores(valorPar, valorImpar, "vetores");
        }

        static void ExibirVetores(int[] pares, int[] impares, string info)
        {
            foreach (var indice in pares)
            {
                if (indice != 0)
                {
                    Write(" {0} |", indice);
                }
            }
            Write(" => Vetor com {0} pares\n\n",info);
            foreach (var indice in impares)
            {
                if (indice != 0)
                {
                    Write(" {0} |", indice);
                }
            }
            Write(" => Vetor com {0} ímpares\n\n",info);
        }

    }
}
