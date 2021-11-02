using System;
using static System.Console;

namespace Desafio2
{
    public class Exerc1
    {
        //Exercício 1: Escreva um programa para ler os valores e somar duas matrizes 4x4.
        //Mostrar a Matriz resultante.

        private int[,,] _matriz;
        private int _indice = 4, _count, _aux=3;

        public Exerc1()
        {

        }

        public void SomaMatriz()
        {
            _matriz = new int[_aux, _indice, _indice];
            for (int m = 0; m < _aux; m++)
            {
                if (m < (_aux-1))
                {
                    Write("|");
                    for (int l = 0; l < this._indice; l++)
                    {
                        for (int c = 0; c < this._indice; c++)
                        {
                            Random rand = new Random();
                            _matriz[this._count, l, c] = rand.Next(-5, 5);
                            Write("  {0}  ", _matriz[this._count, l, c]);
                        }
                    }
                    Write("|\t=\t {0}º Matriz", _count + 1);
                    _count++;
                    WriteLine();
                }
                else
                {
                    WriteLine("\n================================ ---------- { RESULTADO DA SOMA } ---------- ================================\n");
                    Write("|");
                    for (int l = 0; l < _indice; l++)
                    {
                        for (int c = 0; c < _indice; c++)
                        {
                            _matriz[this._count, l, c] = (_matriz[(this._count - 2), l, c]) + (_matriz[(this._count - 1), l, c]);
                            Write("  {0}  ", _matriz[_count, l, c]);
                        }
                    }
                    Write("|\n\n\n", _count + 1);
                }
            }

        }
    }
}
