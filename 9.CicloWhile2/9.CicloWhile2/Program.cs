using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;
            Console.WriteLine("Ingrese la cantidad de números a evaluar:");
            cantidadNumeros=int.Parse(Console.ReadLine());

            while (cantidadNumeros>=contador)
            {
                contador++;
                Console.WriteLine("Ingrese el número a evaluar:");
                numero=int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    contadorNegativos++;
                }
                else
                {
                    if (numero > 0)
                    {
                        contadorPositivos++;
                    }
                    else
                    {
                        contadorCeros++;
                    }
                }
            }
            Console.WriteLine($"Cantidad positivos: {contadorPositivos}, cantidad negativos: {contadorNegativos}, cantidad ceros: {contadorCeros}");
        }
    }
}
