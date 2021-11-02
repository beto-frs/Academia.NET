using Newtonsoft.Json;
using static System.Console;

namespace Desafio2
{
    public class Exerc3
    {
        // Exercício 3: A Federação Gaúcha de Futebol contratou um estudante de Ciência da Computação
        // para fazer um levantamento estatístico do resultado de vários Grenais.
        // Escreva um algoritmo que leia para cada Grenal,
        // o número de gols marcados pelo Grêmio e o número de gols marcados pelo Internacional,
        // imprimindo o nome do time vitorioso ou a palavra EMPATE. Após, ele deve escrever a mensagem:

        // Novo Grenal(1. Sim 2. Não)?
        // e solicitar uma resposta.Se a resposta for 1,
        // o algoritmo deve solicitar novamente o número de gols marcados pelos times em uma nova partida;
        // se a resposta for 2, ele deve ser encerrado imprimindo:

        // • quantos Grenais fizeram parte da estatística;
        // • o número de vitórias do Grêmio;
        // • o número de vitórias do Internacional;
        // • o número de empates; e
        // • uma mensagem indicando qual o time que venceu o maior número de Grenais(ou “Não houve vencedor”).

        public Exerc3()
        {

        }
        private int _countGrenal, _intWinner, _greWinner, _intGols, _greGols;
        private double _greMedia, _intMedia;

        public void Grenal()
        {
            Clear();
            Write("Novo Grenal? (Digite 1 para Sim | 2 para Não | Qualquer tecla pra Sair) :");
            string escolha = ReadLine();
            if (escolha == "1")
            {
                Jogo();
            }
            else if (escolha == "2")
            {
                Status();
            }
            else
            {

            }
        }

        public void Jogo()
        {
            Clear();
            _countGrenal++;
            Write("Quantos gols o Inter fez?");
            int inter = int.Parse(ReadLine());
            Write("Quantos gols o Grêmio fez?");
            int gremio = int.Parse(ReadLine());

            if (inter > gremio)
            {
                _intWinner++;
                WriteLine("\nInter VENCEU!!!\n\n");
            }
            else if (gremio > inter)
            {
                _greWinner++;
                WriteLine("\nGremio VENCEU!!!\n\n");
            }
            else
            {
                WriteLine("\nEMPATE!!!\n\n");
            }
            _intGols += inter;
            _greGols += gremio;
            _greMedia = _greGols / _countGrenal;
            _intMedia = _intGols / _countGrenal;
            ReadLine();
            Grenal();
        }

        public void Status()
        {
            Clear();
            WriteLine("Teve {0} Grenal.\n\n" +
                "Total de vitórias do Inter ==>\t{1}\n" +
                "Total de gols do Inter ==>\t{2}\n" +
                "Média de gols por partida ==>\t{0}\n", _countGrenal, _intWinner, _intGols, _intMedia);
           
            WriteLine("Total de vitórias do Gremio ==>\t{0}\n" +
                "Total de gols do Gremio ==>\t{1}\n" +
                "Média de gols por partida ==>\t{0}\n", _greWinner, _greGols, _greMedia);
            if (_intWinner > _greWinner)
            {
                WriteLine("Inter levando vantagem...");
            }
            else if(_intWinner < _greWinner)
            {
                WriteLine("Gremio levando vantagem...");
            }
            else
            {
                WriteLine("DISPUTA ACIRRADA...");
            }
            ReadLine();
            Grenal();

        }


    }
}
