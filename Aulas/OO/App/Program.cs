using System;
using static System.Console;
using OO.Model;

namespace OO
{
    class Program
    {
        static void Main()
        {
            Animal a = new("Fila da puta","Arrombado","Binário","Zé");
            a.Dormir();
            a.Caminhar();
            a.EmitirSom("Gemendo...");
            
            
        }
    }
}
