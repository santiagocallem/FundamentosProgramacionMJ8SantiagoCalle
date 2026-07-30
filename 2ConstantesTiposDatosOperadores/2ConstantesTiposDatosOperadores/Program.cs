using System;
using System.Management.Instrumentation;

namespace _2ConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva="19%";
            string nombre = "Luis";
            nombre = "Carlos";
            //iva = "20%"; a una constante no le puedo cambiar el valor
            //Tipos de datos
            byte dato1 = 255;
            int dato2 = -12365;
            long dato3 = 123565656;
            float dato4 = 5.3f;
            double dato5 = 12.36d;
            decimal dato6 = 12356.43524626235m;
            char dato7 = 'x'; //un solo caracter
            string dato8 = "por la salida de elden ring elden ring e tu salida saliste del videojuego psss un saludo a la skrrrrr y en velda a todos ustedes de elden ring";
            bool dato9 = true; //true o false
            object dato19 = new object();

            //OPERADORES
            //Operadores númericos
            //Cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12:{1}",dato11,dato12);
            //Operadores Aritméticos
            int dato13 = 3 + 5;
            Console.WriteLine("La suma es :{0}", dato13);                
            int dato14 = dato13 - 2;
            Console.WriteLine ("La suma es :{0}",dato14);
            int dato15 = 3 * 5;
            Console.WriteLine ("La suma es :{0}",dato15);
            float dato16 = 5f / 3f;
            Console.WriteLine ("La suma es :{0}",dato16);
        }
    }
}
