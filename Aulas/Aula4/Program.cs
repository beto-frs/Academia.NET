using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void exerc1()
        {
            //estruturas condicionais             
            // criar if, else if, if dentro if
            // /* switch case -> estruturas seletivas -> selecionar -> menu -> servir para criar menus e comparações mais "simples"
            // só funciona/compara inteiro e caracteres -> não poderemos comparar strings (existem funçoes), pontos flutuantes como float e double
            // */
            int n, x;
            Console.WriteLine("Digite um número ");
            n = int.Parse(Console.ReadLine());
            switch (n) // variável de controle será o N, ou seja, as comparações serão nesta variável
            {
                case 0:
                    Console.WriteLine("O n vale 0");
                    x = 11;
                    Console.WriteLine("Oi");
                    break; //} pra finalizar este case é break                case 10:
                    Console.WriteLine("O n vale 10");
                    x = 11; // atribuição                    Console.WriteLine("O valor do x é " + x);
                    x = x * 2;
                    Console.WriteLine("O valor do agora x é " + x);
                    break;
                case 5:
                    Console.WriteLine("Digitou 5");
                    break;
                default:
                    Console.WriteLine("Digite um valor válido!");
                    break;
            }

        }

        public void Escolha()
        {
            /*
             * Escreva um programa que pede para o usuário digitar um valor entre 1 e 12, e então mostre na tela o mês correspondente. Caso o usuário digite um valor fora do intervalo, mostre uma mensagem indicando que é um mês inválido.
        */
            Console.WriteLine("Digite um numero equivalente ao mês:");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;


                default:
                    Console.WriteLine("Inválido");
                    break;
            }

        }

        public void Nome()
        {
            /*
             * Implemente na calculadora desenvolvida as seguintes funções: 
             * Se a operação digitada for “+”, 
             * será efetuada a soma; 
             * Se a operação digitada for “-”, 
             * será efetuada a subtração; 
             * Se a operação digitada for “x”, 
             * será efetuada a multiplicação Se a operação digitada for “/”, 
             * será efetuada a divisão; 
             * Se não for inserida nenhuma das operações anteriores, 
             * deve ser apresentado uma mensagem para 
             * digitar uma operação válida e apresente o resultado das quatro operações.
             */
            Console.WriteLine("Calculadora");
            Console.Write("Digite um primeiro numero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo numero:");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite um primeiro numero:");


        }

        public void nome2()
        {
            /*
             * Uma loja fornece 10% de desconto para funcionários e 
             * 5% de desconto para clientes vips. 
             * Faça um programa que calcule o valor total a ser pago por uma pessoa. 
             * O programa deverá ler o valor total da compra efetuada 
             * e um código que identifique se o comprador é um cliente comum (1), 
             * funcionário (2) ou vip (3)
             */


        }

        public void nome3()
        {
            /*
             * Crie um programa para fazer a leitura de um numero. 
             * Se o numero for impar, transforme este numero em par. 
             * Se for par, mantenha o mesmo numero.*/
            Console.Write("Digite um numero inicial:");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um numero final:");
            int n2 = int.Parse(Console.ReadLine());



        }

        public void repeticao()
        {
            /*Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, 
             * e então mostre na tela todos os números de 0 a 100, pulando de x em x.
             */
            Console.Write("Digite um numero:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100; i = i + x)
            {
                Console.WriteLine(i);
            }


        }

        public void exerc2()
        {
            char letra;
            Console.WriteLine("Digite uma letra ou caractere");
            letra = char.Parse(Console.ReadLine());
            switch (letra)
            {
                case 'r':
                    Console.WriteLine("A letra digitada foi r");
                    break;
                case ':':
                    Console.WriteLine("Foi digitado :");
                    break;
                case '1':
                    Console.WriteLine("Foi digitado 1");
                    break;
                default:
                    Console.WriteLine("Não foi digitado nada que prestasse");
                    break;
            }


        }

        public void Calculadora()
        {
            /*Implemente na calculadora desenvolvida as seguintes funções: 
             * Se a operação digitada for “+”, 
             * será efetuada a soma; Se a operação digitada for “-”, 
             * será efetuada a subtração; Se a operação digitada for “x”, 
             * será efetuada a multiplicação Se a operação digitada for “/”, 
             * será efetuada a divisão; Se não for inserida nenhuma das operações anteriores, 
             * deve ser apresentado uma mensagem para digitar uma operação válida 
             * e apresente o resultado das quatro operações.*/

            char op;
            int n1, n2;
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação \n+ soma \n- subtração\nx - multiplicação\n/ - divisão");
            op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("O resultado da soma é: " + (n1 + n2));
                    break;
                case '-':
                    Console.WriteLine("O resultado da subtração é: " + (n1 - n2));
                    break;
                case 'x':
                    Console.WriteLine("O resultado da multiplicação é: " + (n1 * n2));
                    break;
                case '/':
                    Console.WriteLine("O resultado da divisão é: " + (n1 / n2));
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    Console.WriteLine("Soma: " + (n1 + n2) + "\nSubtração: " + (n1 - n2) + "\nMultiplicação: " + (n1 * n2) + "\nDivisão: " + (n1 / n2));
                    break;
            }


        }

        public void Ternario()
        {
            static void Main(string[] args)
            {
                /* operador ternário -> tudo que o ternário faz , o if faz...
                * forma simplicada da estrutura if-else -> não é muito usual 
                * operador ternário "?"
                * condição ? instrução1 : instrução 2 */
                int i;
                Console.WriteLine("Digite um valor: ");
                i = int.Parse(Console.ReadLine());
                // Se o numero digitado for par, deve mostrar o numero            // Se for impar, deve transformar este numero em par -> 1 3 5 7 9 11             i =  (i % 2 == 0) ? i : i+1 ;
                Console.WriteLine("Resultado do operador ternário: " + i);
            }
        }
    }
}
