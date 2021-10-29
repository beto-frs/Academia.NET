### Último exercício:



```C#
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
```

