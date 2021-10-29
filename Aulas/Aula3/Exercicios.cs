using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exercicios
    {
        public void Zero()
        {
            int valor;

            Console.WriteLine("Digite um valor:");
            valor = int.Parse(Console.ReadLine());

            if (valor > 0)
            {
                Console.WriteLine("O valor é positivo!");
            }
            else if (valor < 0)
            {
                Console.WriteLine("O valor é negativo!");
            }
            else
            {
                Console.WriteLine("O valor é zero!");
            }
        }

        public void Acerto()
        {
            /*Declare uma variável int e armazene um valor qualquer nela 
             * (direto no código fonte). Depois disso, solicite ao usuário informar um numero!
             * Verifique se o numero que o usuário digitou é igual ao que você armazenou ou não, 
             * e informe isto ao usuário!*/
            int valor = 5;
            int digitado;

            Console.WriteLine("Digite um valor");
            digitado = int.Parse(Console.ReadLine());

            if (valor == digitado)
            {
                Console.WriteLine("Os valores são iguais!");
            }
            else
            {
                Console.WriteLine("Os valores são diferentes!");
            }

        }

        public void Acerto2()
        {
            Console.Write("Digite um valor:");
            int n1, n2;
            Random r = new Random();
            n1 = r.Next(1, 10);
            n2 = int.Parse(Console.ReadLine());

            if (n2 == n1)
            {
                Console.Write("Acertou Mizeravi!!!");
            }

            Console.Write("Errou ziiica!");
        }

        public void Acerto3()
        {
            Console.Write("Digite um valor de 1 a 10 e tente adivinhar:");
            Random r = new Random();
            int n1 = r.Next(1, 10);
            int n2 = int.Parse(Console.ReadLine());

            if (n2 == n1)
            {
                Console.Write("Acertou Mizeravi!!!");

            }

            else if (n2 < n1)
            {
                Console.Write("Mais pra cima");
            }

            else
            {
                Console.Write("Mais pra baixo");
            }
        }

        public void Acerto4()
        {
            int senha;
            Console.WriteLine("Digite a senha");
            senha = int.Parse(Console.ReadLine());

            if (senha == 5)
            {
                Console.WriteLine("Login sucess!");
            }
            else
            {
                if (senha > 5)
                {
                    Console.WriteLine("Valor informado maior que a senha!");
                }
                else
                {
                    Console.WriteLine("Valor informado menor que a senha!");
                }
            }

        }

        public void Escolha()
        {
            /*Leia 2 números do usuário, após isso, mostre esta mensagem ao usuário:
            * “Informe 1 para soma, 2 para subtração, 3 para multiplicação e 4 para divisão”
            * Leia a escolha do usuário e faça o que ele pediu!*/

            Console.Write("Digite o primeiro numero:");
            double n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero:");
            double n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe 1 para soma\n2 para subtração\n3 para multiplicação\n4 para divisão");
            int n3 = int.Parse(Console.ReadLine());
            double n4;
            if (n3 == 1)
            {
                n4 = n1 + n2;
                Console.Write("Resultado: {0}", n4);
            }
            else if (n3 == 2)
            {
                n4 = n1 - n2;
                Console.Write("Resultado: {0}", n4);
            }
            else if (n3 == 3)
            {
                n4 = n1 * n2;
                Console.Write("Resultado: {0}", n4);
            }
            else if (n3 == 4)
            {
                n4 = n1 / n2;
                Console.Write("Resultado: {0}", Math.Round(n4, 2));
            }
            else
            {
                Console.Write("Opção incorreta!");
            }

        }

        public void Salario()
        {
            Console.Write("Digite o salário:");
            double salario = double.Parse(Console.ReadLine());

            double[] porc = { 0.05, 0.08, 0.1 };

            if (salario <= 900)
            {
                Console.WriteLine("O salario é R$ {0}, terá um aumento de 5%, e com reajuste será R$ {1}", salario, Math.Round((salario * 0.05) + salario), 2);
            }
            else if (salario > 900 && salario <= 1400)
            {
                Console.WriteLine("O salario é R$ {0}, terá um aumento de 8%, e com reajuste será R$ {1}", salario, Math.Round((salario * 0.08) + salario), 2);
            }
            else
            {
                Console.WriteLine("O salario é R$ {0}, terá um aumento de 10%, e com reajuste será R$ {1}", salario, Math.Round((salario * 0.1) + salario), 2);
            }
        }

        public void Triangulo()
        {
            Console.Write("Digite 3 valores para os lados do triangulo:");
            Console.Write("Digite 0 1º lado:");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Digite 0 2º lado:");
            double lado2 = double.Parse(Console.ReadLine());
            Console.Write("Digite 0 3º lado:");
            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 < (lado2 + lado3) && lado2 < (lado1 + lado3) && lado3 < (lado2 + lado1))
            {
                if (lado1 == lado2 && lado3 == lado2 && lado1 == lado3)
                {
                    Console.Write("Triangulo Equilátero");
                }

                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    Console.Write("Triangulo Isóceles");
                }
                else
                {
                    Console.Write("Triangulo Escaleno");
                }
            }
            else
            {
                Console.Write("Não é triângulo");
            }
        }

        public void Doador()
        {
            /*
             * Para doar sangue é necessário ter entre 18 e 67 anos. 
             * Faça um aplicativo que pergunte a idade de uma pessoa e 
             * diga se ela pode doar sangue ou não. Use alguns dos operadores 
             * lógicos OU (||) e E (&&).
            */
            Console.ForegroundColor = ConsoleColor.White;
            string nome;
            int idade;
            Console.WriteLine("Identificação do doador!");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 67)
            {
                Console.Write("Qual o tipo sanguíneo (Ex: A+ ou a+) :");
                string tipo = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Caro(a) {0}, você pode ser doador de sangue", nome);
                TipoSangue(tipo);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Caro(a) {0}, você não pode ser doador de sangue", nome);
            }
            

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void TipoSangue(string tipoSangue)
        {
            string[] APositivo = { "A+", "AB+" };
            string[] ANegativo = { "A+", "A-", "AB+","AB-" };

            string[] BPositivo = { "B+", "AB+" };
            string[] BNegativo = { "B+", "B-", "AB+", "AB-" };

            string[] ABPositivo = { "AB+" };
            string[] ABNegativo = { "AB+", "AB-" };

            string[] OPositivo = { "A+", "B+", "AB+", "O+" };
            string[] ONegativo = { "Todos os tipos" };

            //int TamAPositivo = APositivo.Length;

            switch (tipoSangue)
            {
                case "A+":
                case "a+":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < APositivo.Length; i++)
                    {
                        Console.Write(APositivo[i] + ", ");
                    }
                    break;

                case "A-":
                case "a-":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < ANegativo.Length; i++)
                    {
                        Console.Write(ANegativo[i] + ", ");
                    }
                    break;
                case "B+":
                case "b+":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < BPositivo.Length; i++)
                    {
                        Console.Write(BPositivo[i] + ", ");
                    }
                    break;

                case "B-":
                case "b-":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < BNegativo.Length; i++)
                    {
                        Console.Write(BNegativo[i] + ", ");
                    }
                    break;

                case "AB+":
                case "ab+":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < ABPositivo.Length; i++)
                    {
                        Console.Write(ABPositivo[i] + ", ");
                    }
                    break;

                case "AB-":
                case "ab-":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < ABNegativo.Length; i++)
                    {
                        Console.Write(ABNegativo[i] + ", ");
                    }
                    break;

                case "O+":
                case "o+":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < OPositivo.Length; i++)
                    {
                        Console.Write(OPositivo[i] + ", ");
                    }
                    break;

                case "O-":
                case "o-":
                    Console.Write("Você pode ser doar para: ");
                    for (int i = 0; i < ONegativo.Length; i++)
                    {
                        Console.Write(ONegativo[i] + ", ");
                    }
                    break;

                default:
                    Console.Write("Tipo de sangue inválido");
                    break;
            }




            

            
            
        }


    }
}
