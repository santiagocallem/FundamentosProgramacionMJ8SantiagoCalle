using System;

namespace _15.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   // Arreglos Unidimensionales o vector

            int[] numeros= new int[5];
            numeros[0] = 15;
            numeros[1] = 56;
            numeros[2] = 20;
            numeros[3] = 47;
            numeros[4] = 27;
            //numeros[5] = 100; No es posible porque la posición 6 con índice 5 no existe
            Console.WriteLine($"El dato alamecnado en la posición 4 con índice 3 es: {numeros[3]}");

            float[] notas = new float[3];
            notas[0] = 3.6f;
            notas[1] = 4.3f;
            notas[2] = 5.0f;
            //Otras formas de declarar e inicializar

            char[] simbolos = new char[] { '?', '(', '5', 'f' };
            bool[] valoresVerdad = { true, false, true, true, false };

            //Recorrer ub vector para llenarlo de datos
            string[] nombres = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese el nombre para la P{i+1}: I{i}");
                nombres[i] = Console.ReadLine();
            }

            //Recorrer el vector para recuperar los datos almacenados en el vector
            for(int i = 0;i < nombres.Length;i++)
            {
                Console.WriteLine($" {nombres[i]} |");
            }*/

            //Crear un algoritmo llamado "enteros" de 100 elementos asignar el número 10 en cada una e las posiciones del arrelgo. Leer el contenido de cada elemento y mostrarlo en pantalla.

            int[] enteros = new int[100];

            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = 10;
            }

            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = 10;
                Console.WriteLine($"El valor almacenado en la posición {i + 1} es: {enteros[i]}");
            }
        }
    }
}
