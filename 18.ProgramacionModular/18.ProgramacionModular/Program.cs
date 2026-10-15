using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static int AñoActual = 2026;
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al curso de Fundamentos de Programación");
            MostrarMensaje("Santiago");
            Console.WriteLine($"Santiago tiene {CalcularEdad()} años");
            MostrarMensaje("Manolin Pinguin");
            int añoNacimiento = 2003;
            Console.WriteLine($"Manolin Pinguin tiene {CalcularEdad(añoNacimiento, AñoActual)} años");
            MostrarMensaje("Santiago", "Calle Moreno");
            Console.ReadKey();
            BorrarPantalla();
        }
        static int CalcularEdad(int añoNacimiento, int añoActual)
        {
            return añoActual - añoNacimiento;
        }
        static int CalcularEdad()
        {
            int añoNacimiento = 2008;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso Fundamentos de Programación");
        }
        static void MostrarMensaje(String nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso Fundamentos de Programación");
        }

    }
}