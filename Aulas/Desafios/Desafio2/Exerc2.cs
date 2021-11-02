using System;
using static System.Console;

namespace Desafio2
{
    public class Exerc2
    {
        //Exercício 2: Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
        //Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

        private int[,] _matriz1, _matriz2;
        private int _linha = 3, _coluna = 4;

        public Exerc2()
        {

        }

        public void TransporMatriz()
        {
            _matriz1 = new int[_linha, _coluna];
            _matriz2 = new int[_coluna, _linha];
            
            for (int l = 0; l < this._linha; l++)
            {
                for (int c = 0; c < this._coluna; c++)
                {
                    Random rand = new Random();
                    int valor = rand.Next(1, 10);
                    _matriz1[l, c] = valor;
                    _matriz2[c, l] = valor;
                    
                    Write(" {0} ",_matriz1[l,c]);
                }
                Write("\n");
            }
            WriteLine("-------------------------------");
            Write("Matriz {0} x {1}\n\n",_linha,_coluna);

            for (int l = 0; l < this._coluna; l++)
            {
                for (int c = 0; c < this._linha; c++)
                {
                    Write(" {0} ", _matriz2[l, c]);

                }
                Write("\n");
            }
            WriteLine("-------------------------------");
            Write("Matriz {0} x {1}\n\n", _coluna, _linha);
        }


    }
}
