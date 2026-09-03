using System;

namespace _12.CicloDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int numerocuenta;
            double saldo = 0;
            int usuarios = 0;
            double sumasaldos = 0;
            string continuar;

            do
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su número de cuenta: ");
                numerocuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su saldo: ");
                saldo = Convert.ToDouble(Console.ReadLine());

                usuarios++;
                sumasaldos += saldo;

                Console.WriteLine("--- Información del usuario ---");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Número de cuenta: " + numerocuenta);
                Console.WriteLine("Saldo: " + saldo.ToString("C"));

                if (saldo >= 3000000)
                {
                    Console.WriteLine("Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine("No es apto para el crédito");
                }

                Console.WriteLine("¿Desea ingresar otro usuario? (s/n): ");
                continuar = Console.ReadLine();


                while (continuar != "s" && continuar != "S" && continuar != "n" && continuar != "N")

                {
                    Console.WriteLine("Respuesta inválida. Escriba S o N:");
                    continuar = Console.ReadLine();
                }
            } while (continuar == "s" || continuar == "S");

            double promediosaldos = sumasaldos / usuarios;

            Console.WriteLine("--- Resultados finales ---");
                Console.WriteLine("Número de usuarios consultados: " + usuarios);
                Console.WriteLine("Promedio de los saldos: " + promediosaldos.ToString("C"));

                Console.WriteLine("Presione una tecla para finalizar...");
                Console.ReadKey();         
     
        }
    }
}
