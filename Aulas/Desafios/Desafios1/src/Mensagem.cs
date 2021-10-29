using System;

namespace Desafio1
{
    public class Mensagem : Calculo
    {
       
        public Mensagem() { }

        public void Inicio()
        {
            Console.Clear();
            Console.WriteLine("============================--{ DESAFIO 1 }--============================\n");
            start:
            try
            {
                Console.Write("Digite o número inicial: ");
                inicial = double.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de loops: ");
                loops = int.Parse(Console.ReadLine());
                Console.Write("Digite o intervalo: ");
                intervalo = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                MensagemErro("Parametros incorretos!");
                goto start;
                
            }
            
            Console.WriteLine("");
            Console.WriteLine("============================--{ EXIBIÇÃO }--============================\n");
            Desafio();
            
        }


        public void Desafio()
        {
            for (int i = 0; i < loops; i++, inicial -= intervalo)
            {
                if (i < loops - 1)
                {
                    Cond(i);
                    aux = result;
                }
                else
                {
                    Cond(i);
                    Console.Write("=> ");
                    MensagemVerde();
                }
            }
            Console.Write("\nDIGITE QUALQUER TECLA PARA CONTINUAR: ");
            Console.ReadLine();
            Reinicio();
        }

        private void MensagemVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Math.Round(result, 2));
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void MensagemErro(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void Reinicio()
        {
            Console.Clear();
            Console.WriteLine("============================--{ Reinciando }--============================\n");
            Console.Write("Deseja realizar outra exibição?\n1 - Sim ou 2 - Não:");
            try
            {
                int resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    Inicio();
                }

            }
            catch (Exception) { }         
        }
    }
}
