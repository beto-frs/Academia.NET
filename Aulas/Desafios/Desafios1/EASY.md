```c#
public class Program
    {
        public static double inicial, aux,result = 0;
        public static int loops, intervalo;
        
        static void Main(string[] args)
        {
            Inicial();
        }

        public static void Exibicao()
        {
            for (int i = 0; i < loops; i++, inicial -= intervalo)
            {
                if (i < loops - 1)
                {
                    Calculo(i);
                    aux = result;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Calculo(i);
                        Resposta();
                    }
                    else
                    {
                        Calculo(i);
                        Resposta();
                    }
                }
            }
        }

        public static void Inicial()
        {
            Console.WriteLine("============================--{ DESAFIO 1 }--============================\n");
            Console.Write("Digite o número inicial: ");
            inicial = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de loops: ");
            loops = int.Parse(Console.ReadLine());
            Console.Write("Digite o intervalo: ");
            intervalo = int.Parse(Console.ReadLine());
            Console.WriteLine("\n============================--{ EXIBIÇÃO }--============================\n");
            Exibicao();
        }

        public static void Calculo(int n1)
        {
            result = inicial / (n1 + 1);
            if (n1 % 2 == 0)
            {
                Console.Write("+ ( {0} / {1} = {2} ) ", inicial, n1 + 1, Math.Round(result, 2));
                result = aux + result;
            }
            else
            {
                Console.Write("- ( {0} / {1} = {2} ) ", inicial, n1 + 1, Math.Round(result, 2));
                result = aux - result;
            }
        }

        public static void Resposta()
        {
            Console.Write("=> ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Math.Round(result, 2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nDigite qualquer tecla para continuar...");
            Console.Write("\n\nDeseja Realizar outra exibição?\n1 - Sim ou Qualquer tecla para Não:");
            int selecao = int.Parse(Console.ReadLine());

            if (selecao == 1)
            {
                Console.Clear();
                Inicial();
            }
        }

    }
```

