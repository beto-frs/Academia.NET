using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Exercicios
    {

        public void Calculos()
        {
            /* Cálculos Matemáticos */
            double valor1;
            double valor2;
            double soma;
            double sub;
            double mult;
            double div;

            Console.Write("Informe o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            soma = valor1 + valor2;
            sub = valor1 - valor2;
            mult = valor1 * valor2;
            div = valor1 / valor2;

            Console.WriteLine("A soma resulta em: " + soma);
            Console.WriteLine("A subtração resulta em: " + sub);
            Console.WriteLine("A multiplicação resulta em: " + mult);
            Console.WriteLine("A divisão resulta em: " + div);

            Console.ReadKey();
        }

        public void Funcionario()
        {
            /* Leia o nome de um funcionário, a quantidade de horas trabalhadas 
             * e o valor da hora. Feito isto, 
             * mostre uma mensagem ao usuário desta maneira:
            O salário de XXXX é XXXXX>> */
            string nome;
            double horas;
            double valorHora;
            double salario;

            Console.WriteLine("Informe o nome do funcionário:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de horas trabalhadas:");
            horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor hora:");
            valorHora = double.Parse(Console.ReadLine());

            salario = horas * valorHora;

            Console.WriteLine("O salário de " + nome + " é de " + salario);
        }

        public void Auxiliar()
        {
            int x = 5;
            int y = 7;

            int aux;
            aux = x;
            x = y;
            y = aux;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void Vendedor()
        {
            /* Faça um programa onde o salario e o percentual de aumento são entradas.
             * A saída é o novo salário.*/

            double salario, percentual;
            Console.WriteLine("Informe o salário atual: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual de aumento: ");
            percentual = double.Parse(Console.ReadLine());

            salario = salario + (salario * percentual) / 100;

            Console.WriteLine("Novo salário: " + salario);
        }

        public void Comissao()
        {
        /* Suponha que um vendedor de carros trabalhe em uma empresa onde todos os veículos custem 30.000 reais. 
         * Faça um programa que leia o nome do funcionário, o seu salario base (Exemplo: 1000), 
         * e a quantidade de veículos vendidos. Para cada veiculo vendido ele recebe 15% de comissão, que deve ser somado ao seu salario. 
         * Apresente o novo salario da mesma forma do exercício anterior.*/

            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o seu salário: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de carros vendidos: ");

            int quantidadeCarrosVendidos = int.Parse(Console.ReadLine());

            double valorBonus = ((double)15 / 100) * 30000;
            double salarioTotal = salarioBase + valorBonus * quantidadeCarrosVendidos;
            Console.WriteLine("O novo salário é {0:f3}", salarioTotal);
            Console.WriteLine("15% de bonus " + valorBonus);
        }

        public void Eleitores()
        {
            /* Para uma eleição, receba o numero de eleitores, 
             * a quantidade de votos brancos, nulos e validos. 
             * Mostre o percentual de cada tipo de voto.*/
            int brancos, nulos, validos;
            int brancosP, nulosP, validosP;
            Console.WriteLine("Informe a quantidade de votos brancos");
            brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de votos nulos");
            nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de votos válidos");
            validos = int.Parse(Console.ReadLine());
            int total = brancos + nulos + validos;
            brancosP = (brancos * 100) / total;
            nulosP = (nulos * 100) / total;
            validosP = (validos * 100) / total;
            Console.WriteLine("O percentual de votos branco é de :" + brancosP);
            Console.WriteLine("O percentual de votos nulos é de :" + nulosP);
            Console.WriteLine("O percentual de votos validos é de :" + validosP);
        }

        public void Media()
        {
            double notasTotal = 0, media;
            int qtdNotas;
        inicio:
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Quantas notas precisa calcular a média?");
                qtdNotas = Convert.ToInt32(Console.ReadLine());
            notas:
                for (int i = 0; i < qtdNotas; i++)
                {
                    double[] notas = new double[qtdNotas];
                    try
                    {
                        Console.Write($"Digite a {i + 1}ª nota:");
                        notas[i] = Double.Parse(Console.ReadLine());
                        if (notas[i] > 10)
                        {
                            MensagemErro("Favor digite somente o intervalo de 0 a 10.");
                        }
                        notasTotal += notas[i];
                    }
                    catch (Exception)
                    {
                        MensagemErro("Favor digite somente números.");
                        goto notas;
                    }
                }
                media = notasTotal / qtdNotas;
                Status(media);
            }
            catch (Exception)
            {
                MensagemErro("Favor digite somente números.");
                goto inicio;
            }



        }


        static void Status(double media)
        {
            string result;
            if (media >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = "Aprovado";
            }
            else if (media < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "Reprovado";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                result = "Recuperação";
            }

            Console.WriteLine("A média das notas digitadas foi: {0}\n" +
                "Status: {1}", Math.Round(media, 1), result);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void MensagemErro(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=========================================");
        }

    }
}
