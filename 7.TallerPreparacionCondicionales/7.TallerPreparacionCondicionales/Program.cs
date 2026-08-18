using System;

namespace _7.TallerPreparacionCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            // EJERCICIO 1: Crear un algoritmo que permita leer tres valores
            // y almacenarlos en las variables numero1, numero2, numero3.
            
            int num1, num2, num3;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num2 != num3 && num1 != num3)

                if (num1 > num2 && num2 > num3 && num1 > num3)
                {
                    Console.WriteLine("El número mayor es: " + num1);
                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num3 + ", " + num2 + ", " + num1);
                }
                else if (num1 > num3 && num3 > num2 && num1 > num2)
                {
                    Console.WriteLine("El número mayor es: " + num1);
                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num2 + ", " + num3 + ", " + num1);
                }
                else if (num2 > num1 && num2 > num3 && num1 > num3)
                {
                    Console.WriteLine("El número mayor es: " + num2);
                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num3 + ", " + num1 + ", " + num2);
                }
                else if (num2 > num1 && num2 > num3 && num3 > num1)
                {
                    Console.WriteLine("El número mayor es: " + num2);
                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num1 + ", " + num3 + ", " + num2);
                }
                else if (num3 > num1 && num3 > num2 && num1 > num2)
                {
                    Console.WriteLine("El número mayor es: " + num3);
                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num2 + ", " + num1 + ", " + num3);
                }
                else if (num3 > num2 && num3 > num1 && num2 > num1)
                {
                    Console.WriteLine("El número mayor es: " + num3);
                    Console.WriteLine("Los números ordenados de menor a mayor son: " + num1 + ", " + num2 + ", " + num3);
                }
                else if (num1 == num2 && num2 == num3 && num1 == num3)
                {
                    Console.WriteLine("Los numeros son iguales o hay un empate entre ellos.");
                }
            */


            byte estado;
            byte municion;

            Console.WriteLine("Ingrese el estado del personaje (invencible (1) o vulnerable (0):");

            estado = byte.Parse(Console.ReadLine());

            Random random = new Random();

            municion = (byte)random.Next(1, 11);

            Console.WriteLine("El personaje tiene " + municion + " balas de munición.");

            if (estado == 1 && municion > 0)
            {
                Console.WriteLine("El personaje esta disparando.");
            }
            else
            {
                Console.WriteLine("El personaje no puede disparar.");
            }
        }
    }
}
