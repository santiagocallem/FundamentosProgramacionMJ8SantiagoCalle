using System;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.

            /*            int[,] matriz = new int[10, 20];
                        int[] sumacolumnas = new int[20];

                        Random rand = new Random();

                        for(int i = 0; i < matriz.GetLength(0); i++) {
                            for(int j = 0; j < matriz.GetLength(1); j++) {
                                matriz[i, j] = rand.Next(1, 101);
                                sumacolumnas[j] += matriz[i, j];
                            }
                        }

                        Console.WriteLine("Matriz generada:");
                        for(int i = 0; i < matriz.GetLength(0); i++) {
                            for(int j = 0; j < matriz.GetLength(1); j++) {
                                Console.Write($"{matriz[i, j],4}");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Suma de los elementos de cada columna:");
                        for(int j = 0; j < sumacolumnas.GetLength(0); j++) {
                            Console.WriteLine($"Columna {j + 1}: {sumacolumnas[j]}");
                        }*/

            //2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla.El programa debe intercambiar la primera fila con la última fila de la matriz.Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas. 
            /*
                        Console.Write("Ingrese el número de filas: ");
                        int n = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el número de columnas: ");
                        int m = int.Parse(Console.ReadLine());

                        int[,] matriz = new int[n, m];

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write($"Ingrese el valor para la posición [{i}, {j}]: ");
                                matriz[i, j] = int.Parse(Console.ReadLine());
                            }
                        }

                        //Imprimir la matriz original

                        Console.WriteLine("Matriz original:");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write($"{matriz[i, j],4}");
                            }
                            Console.WriteLine();
                        }*/


            //3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 5x5 llena de números aleatorios.

            /*            int[,] matriz = new int[5, 5];
                        int[] frecuencia = new int[11]; // Índice 0 no se usará, los números van del 1 al 10

                        Random rand = new Random();

                        // Llenar la matriz con números aleatorios
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                matriz[i, j] = rand.Next(1, 11);
                            }
                        }

                        // Contar la frecuencia de cada número
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                frecuencia[matriz[i, j]]++;
                            }
                        }

                        //Imprimir la matriz generada

                        Console.WriteLine("Matriz generada:");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write($"{matriz[i, j],4}");
                            }
                            Console.WriteLine();
                        }

                        // Imprimir la frecuencia de cada número
                        Console.WriteLine("Frecuencia de cada número del 1 al 10:");
                        for (int k = 1; k <= 10; k++)
                        {
                            Console.WriteLine($"Número {k}: {frecuencia[k]} veces");
                        }*/


            //4. Crea un algotirmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario adivinar la posición de una "X".

            /*            char[,] tablero = new char[5, 5];
                        Random random = new Random();

                        // Llenar tablero con espacios
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                tablero[i, j] = '-';
                            }
                        }

                        // Colocar 3 X sin repetir posiciones
                        int xColocadas = 0;

                        while (xColocadas < 3)
                        {
                            int fila = random.Next(0, 5);
                            int columna = random.Next(0, 5);

                            if (tablero[fila, columna] != 'X')
                            {
                                tablero[fila, columna] = 'X';
                                xColocadas++;
                            }
                        }

                        bool acierto = false;

                        // Tres intentos
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine($"\nIntento {intento}");

                            Console.Write("Ingrese la fila (1-5): ");
                            int filaUsuario = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese la columna (1-5): ");
                            int columnaUsuario = int.Parse(Console.ReadLine());

                            // Convertir de 1-5 a índices 0-4
                            filaUsuario--;
                            columnaUsuario--;

                            if (filaUsuario >= 0 && filaUsuario < 5 &&
                                columnaUsuario >= 0 && columnaUsuario < 5)
                            {
                                if (tablero[filaUsuario, columnaUsuario] == 'X')
                                {
                                    Console.WriteLine("¡ÉXITO! Encontraste una X.");
                                    Console.WriteLine(
                                        $"La X estaba en la posición [{filaUsuario + 1},{columnaUsuario + 1}]"
                                    );

                                    acierto = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No hay una X en esa posición.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Coordenadas inválidas.");
                            }
                        }

                        // Si no acertó, mostrar matriz
                        if (!acierto)
                        {
                            Console.WriteLine("\nERROR. No encontraste ninguna X.");
                            Console.WriteLine("La matriz era:");

                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    Console.Write(tablero[i, j] + " ");
                                }

                                Console.WriteLine();
                            }
                        }*/

            //5. Desarrollar un programa de C# que: a. Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz de enteros. b. Cargue los datos de la matriz ingresándolos por teclado. c. Muestre la matriz ingresada. d. Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser ahora la columna 1. e. Mostrar la nueva matriz.

            int filas, columnas;

            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            // Cargue los datos de la matriz ingresándolos por teclado
            Console.WriteLine("Ingrese los elementos de la matriz:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Muestre la matriz ingresada 

            Console.WriteLine("La matriz ingresada es:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser ahora la columna 1.

            Console.WriteLine("La matriz transpuesta es:");

            int[,] transpuesta = new int[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            // Mostrar la nueva matriz

            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write(transpuesta[i, j] + " ");
                }
                Console.WriteLine();

            }


        }
    }
}
    
