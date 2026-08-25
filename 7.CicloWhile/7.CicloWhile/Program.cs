using System;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            //1. Escribir un algoritmo que permita los primeros 5 números enteros positivos y realizar y mostrar su suma.
            int contador = 1;
            int acumulador = 1;

            while (contador < 5)
            {
                contador++;
                acumulador = acumulador + contador;
            }

            Console.WriteLine($"La suma de los primeros 5 números enteros positivos es: {acumulador}");*/

            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)
            Console.Write("Ingrese un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;
            int contador = 1;

            while (contador <= numero)
            {
                factorial *= contador;
                contador++;
            
            }

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
    }
}
