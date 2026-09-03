using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CicloDoWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. Utilizar la función Random para elegir el número aleatorio.

            byte numeroAleatorio = (byte)new Random().Next(1, 101);
            byte intento;
            do
            {
                Console.Write("Adivina el número (1-100): ");
                intento = byte.Parse(Console.ReadLine());

                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto.");
                }
                else
                {
                    Console.WriteLine("¡Correcto!");
                }
            } while (intento != numeroAleatorio);
        }
    }
}
