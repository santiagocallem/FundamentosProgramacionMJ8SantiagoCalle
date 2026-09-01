using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Ciclo Do While
            int contador = 1;
            int acumulador = 0;

            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/

            //Algoritmo que solicita un número y genero su correspondiente tabla de multiplicar desde el 1 hasta el 10.

            /* int numero;
             int contador = 0;
             int acumulador;
             char seleccion;

             Console.WriteLine("Ingrese un número para generar su tabla de multiplicar: ");
             numero = int.Parse(Console.ReadLine());

             do
             {
                 acumulador = numero * contador;
                 Console.WriteLine($"{numero} x {contador} = {acumulador}");
                 contador++;
             } while (contador <= 10);
             Console.WriteLine("¿Generar otra tabla de multiplicar? Ingrese S o s para si, o cualquier otro caracter para no.");
             seleccion = char.Parse(Console.ReadLine());

             if (seleccion == 's' || seleccion == 'S')
             {
                 Main(args);
             }
             else
             {
                 Console.WriteLine("Gracias por usar el programa.");
             }*/

            //Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el número 100.

            int numero = 2;
            int contador;
            bool esPrimo;

            Console.WriteLine("Números primos hasta el 100:");
            do
            {
                contador = 2;
                esPrimo = true;
                while(contador <=Math.Sqrt(numero))
                {
                    if (numero % contador == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                    contador++;
                }
                if (esPrimo)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }while (numero <= 100);
        }
    }
}
