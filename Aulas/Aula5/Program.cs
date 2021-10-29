using System;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Exerc4();
        }

        static void Exerc()

        {
            /*Escreva um algoritmo leia pelo teclado a quantidade de 
             * alunos de uma turmaOK             
             * * e então,              
             * * para cada aluno, leia suas 3 notas do semestre ok             
             * * e mostre na tela sua média final, ok             
             * * e se está aprovado com nota 6 ou não.*/
            int q, i;
            double n1, n2, n3, media;
            Console.Write("Oi pessoal, tudo bem?\n");
            Console.WriteLine("Oi pessoal, tudo bem?");
            Console.WriteLine("Quantos alunos tem na turma?");
            q = int.Parse(Console.ReadLine());
            for (i = 0; i < q; i++)  //for (i = 1; i <= q; i++)             {
            {                         //fazer a leitura -> aqui dentro, pra cada execução deste laço, é 1 aluno distinto...                 Console.WriteLine("Digite as três notas do aluno " + (i + 1));
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
                media = (n1 + n2 + n3) / 3;
                Console.Write("O aluno " + (i + 1) + " tem média = " + media);
                if (media >= 6)
                {
                    Console.WriteLine(" e está aprovado!");
                }
                else
                {
                    Console.WriteLine(" e está reprovado!");
                }
            }
        }



        static void Exerc2()
        {
            /*Faça um programa que leia um número e apresente a tabuada deste número.*/
            int n, i;
            Console.WriteLine("Digite um número :");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
                //Console.WriteLine(n+"*"+i+"="+(n*i));            }
            }
        }

        static void Exerc3()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i * 2.54);
            }

        }

        static void Exerc4()
        {
            Console.WriteLine("Digite o número fatorial:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(n * (n - i));
            }
        }

        static void Exerc5()
        {
            /*Escreva um programa em C# que gera números entre 1000 e 1999             
             * * e mostre aqueles que divididos por 11 dão resto 5.             
             * int i;            
             * for (i = 1000; i <= 1999; i++)            {                
             * if (i % 11 == 5)                
             * {                    
             * Console.WriteLine("O número " + i + " dividido por 11 tem resto = 5");                }
             * }            
             */

            /*Escreva um algoritmo que pergunte ao usuário qual o valor inicial da contagem, 
             * qual o valor final, e se            
             * * ele deseja pular os valores pares ou os valores ímpares. 
             * Após, faça um laço de repetição que mostre            
             * * os valores desejados. */
            int inicio, fim, i;
            bool par = true; // par == true -> mostra pares e se for false mostra ímpares.            char p;
            Console.WriteLine("Digite um valor para iniciar o laço: ");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para o fim  do laço: ");
            fim = int.Parse(Console.ReadLine());
            Console.WriteLine("Para mostrar os pares, digite 'p', para mostrar os ímpares, digite false 'i':");
            char p = char.Parse(Console.ReadLine());
            if (p == 'p')
            {
                par = true;
            }
            else if (p == 'i')
            {
                par = false;
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
            for (i = inicio; i <= fim; i++)
            {
                if (par)
                //if (par == true) i++ => i=i+1  {
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Apresentando os pares: " + i);
                    }
                }


                else
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("Apresentando os impares: " + i);
                    }
                }
            }
        }

        static void Exerc6()
        {

            /*Escreva um algoritmo leia continuamente pelo teclado o valor de uma variável inteira chamada                op, e só finalize a execução do programa quando o valor lido para op seja zero.*/
            int op, i;
            for (i = 0; true; i++)//while(true)  
            {
                Console.WriteLine("Digite um valor para op");
                op = int.Parse(Console.ReadLine());
                if (op == 0)
                {
                    break;
                }

            }
        }

        static void Exerc7()
        {

            int i, j;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
                for (j = 0; j <= 10; j++)
                {
                    Console.WriteLine("    j = " + j);
                }
            }

        }

        public void Exerc8()
        {
            int i, j;
            for (i = 0; i <= 10; i++)
            {
                for (j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + j + " = " + (i * j));
                }
                Console.WriteLine("---------------------------------");
            }
        }

        public void Exerc9()
        {
            int i, n, fat = 1;
            Console.WriteLine("Digite o número que deseja calcular o fatorial: ");
            n = int.Parse(Console.ReadLine());
            /* 5! =              * 5x4x3x2x1 = 120 */
            for (i = n; i >= 1; i--)//for (i = 1; i <= n; i++)            {
                fat = fat * i; //fat*=i;                  }
            Console.WriteLine("O valor do fatorial de " + n + " = " + fat);
        }
    }
}

