using System;

namespace _19.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }
        static void MostrarMenu()
        {
            Console.WriteLine("----------------MENÚ----------------");
            Console.WriteLine("1. Suma                      2. Resta");
            Console.WriteLine("3. Multiplicación            4. División");
            Console.WriteLine("0. Salir");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ingrese una opción del menú: ");
        }
        static float Division()
        {
            Console.WriteLine("Ingrese el número1: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número2: ");
            float numero2 = float.Parse(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre cero.");
                return 0;
            }
            return numero1 / numero2;
        }
        static float Resta()
        {
            Console.WriteLine("Ingrese el número1: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número2: ");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;
        }
        static float Multiplicacion()
        {
            float multiplicacion = 1;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("¿Desea seguir multiplicando? (s: continuar)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("¿Desea seguir sumando? (s: continuar)");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');
            return suma;
        }

        static void RealizarOperaciones(int opcion)
        {
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La SUMA de los números ingresados es {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La RESTA de los números ingresados es {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La MULTIPLICACIÓN de los números ingresados es {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La DIVISIÓN de los números ingresados es {Division()}");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }
            Console.WriteLine("Programa finalizado.");
        }
        static int CapturarOpcion()
        {
            int opcion = 0;
            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese una opción válida.");
                opcion = CapturarOpcion();
            }
            return opcion;
        }
    }
}