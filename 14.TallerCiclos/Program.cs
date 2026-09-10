using System;
using System.Diagnostics.Contracts;

namespace _14.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, introducir tantas calificaciones como así desee,en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente. 

            /*       double nota;
                   double suma = 0;
                   int totalnotas = 0;
                   string respuesta;

                   do
                   {
                       Console.WriteLine("Ingrese una calificación: ");
                       nota = double.Parse(Console.ReadLine());

                       suma = suma + nota;
                       totalnotas = totalnotas + 1;

                       suma += nota;
                       totalnotas++;

                       Console.WriteLine("¿Deseas ingresar otra calificación? ('s' para continuar, cualquier otro carácter para finalizar.): ");
                       respuesta = Console.ReadLine();

                   } while (respuesta == "s" || respuesta == "S");

                   double promedio = suma / totalnotas;

                   Console.WriteLine($"El promedio de calificaciones es {promedio,2}");*/


            //2. Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado.  Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/ b el residuo es 0, en C# utilizar el operador Mod para obtener el residuo de una división de dos números.

            /*int numero;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Los divisores de este número son: ");

            for(int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                 {

                  Console.WriteLine(i);
                 }
            }*/

            //3. Dados dos números enteros ingresados por teclado: b que es la base y e que es el exponente, se requiere calcular el resultado de la potenciación.

            /*int nbase;
            int exponente;
            int resultado;
            string respuesta;

            do
            {
                Console.WriteLine("Ingrese la base: ");
                nbase = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el exponente: ");
                exponente = int.Parse(Console.ReadLine());

                resultado = 1;

                for (int i = 1; i <= exponente; i++)
                {
                    resultado = resultado * nbase;
                }

                Console.WriteLine($"El resultado es: {resultado}.");

                Console.WriteLine("¿Desea realizar otra potencia? (s/n)");
                respuesta = Console.ReadLine();

            } while (respuesta == "s" || respuesta == "S");*/

            //4. Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilómetros durante 10 días, para determinar si es apto para la prueba de 5 kilómetros.

            /*double tiempo;
            double suma = 0;
            double promedio;
            bool supera20 = false;
            bool menor15 = false;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el tiempo de la prueba " + i + ": ");
                    tiempo = double.Parse(Console.ReadLine());

                suma = suma + tiempo;

                if (tiempo > 20)
                {
                    supera20 = true;
                }

                if (tiempo < 15)
                {
                    menor15 = true;
                }
            }

            promedio = suma / 10;

            Console.WriteLine($"Promedio: {promedio}.");

            if (!supera20 && menor15 && promedio <= 18)
            {
                Console.WriteLine("El atleta es apto.");
            } 
            else
            {
                Console.WriteLine("El atleta NO es apto.");
            }*/

            //5. Se aplicó una encuesta a n personas solicitando su opinión sobre el tema del servicio militar obligatorio para las mujeres. Las opciones de respuesta fueron: a favor, en contra y no responde. Se solicita un algoritmo que calcule qué porcentaje de los encuestados marcó cada una de las respuestas.

            /*int n;
            int respuesta;
            int afavor = 0;
            int encontra = 0;
            int noresponde = 0;

            Console.WriteLine("Ingrese la cantidad de personas encuestadas. ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Persona " + i);
                Console.WriteLine("1. A favor.");
                Console.WriteLine("2. En contra.");
                Console.WriteLine("3. No responde.");

                Console.WriteLine("Respuesta: ");
                respuesta = int.Parse(Console.ReadLine());

                if(respuesta == 1)
                {
                    afavor++;
                }
                else if (respuesta == 2)
                {
                    encontra++;
                }
                else if(respuesta == 3)
                {
                    noresponde++;
                }
            }

            double procentajeafavor = (afavor * 100) / n;
            double porcentajeencontra = (encontra * 100) / n;
            double porcentajenoresponde = (noresponde * 100) / n;

            Console.WriteLine("Resultados: ");
            Console.WriteLine("A favor: " + procentajeafavor + "%");
            Console.WriteLine("En contra: " + porcentajeencontra + "%");
            Console.WriteLine("No responde: " + porcentajenoresponde + "%");
        }*/

            //6. Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos de esos números son positivos, cuántos negativos, cuántos son neutros (0); además que imprima por pantalla la sumatoria de los numeros positivos y la de los negativos.

            /*int numero;
            int npositivos = 0;
            int nnegativos = 0;
            int nneutros = 0;
            int sumapositivos = 0;
            int sumanegativos = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Ingrese el número " + i + ": ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    npositivos++;
                    sumapositivos += numero;
                }
                else if (numero < 0)
                {
                    nnegativos++;
                    sumanegativos += numero;
                }
                else
                {
                    nneutros++;
                }
            }

            Console.WriteLine($"Cantidad de positivos: {npositivos}.");
            Console.WriteLine($"Cantidad de negativos:{ nnegativos}.");
            Console.WriteLine($"Cantidad de neutros: {nneutros}.");
            Console.WriteLine($"Suma total de los números positivos: {sumapositivos}.");
            Console.WriteLine($"Suma total de los números negativos: {sumanegativos}.");*/

            //7. Una persona desea realizar un muestreo con 70 personas para determinar el promedio de peso de los niños, jóvenes, adultos y viejos que existen en su zona y cuántos son de cada una de las categorías. Las categorías estan dadas así: Niños: 0-13 ; Jóvenes: 14-30 ; Adultos: 31-60 ; Viejos 61 en adelante.

            /*            int edad;
                        double peso;
                        int ninos = 0;
                        int jovenes = 0;
                        int adultos = 0;
                        int viejos = 0;
                        double pesoninos = 0;
                        double pesojovenes = 0;
                        double pesoadultos = 0;
                        double pesoviejos = 0;

                        for (int i = 1; i<= 70; i++)
                        {
                            Console.WriteLine("Ingrese la edad de la persona " + i + ": ");
                            edad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el peso de la persona " + i + ": ");
                            peso = int.Parse(Console.ReadLine());

                            if (edad >= 0 && edad <= 13)
                            {
                                ninos++;
                                pesoninos += peso;
                            }
                            else if (edad >= 14 && edad <= 30)
                            {
                                jovenes++;
                                pesojovenes += peso;
                            }
                            else if(edad >= 31 && edad <= 60)
                            {
                                adultos++;
                                pesoadultos += peso;
                            }
                            else
                            {
                                viejos++;
                                pesoviejos += peso;
                            }
                        }

                        Console.WriteLine("Resultados: ");
                        Console.WriteLine($"Niños: {ninos}.");
                        Console.WriteLine($"Jóvenes: {jovenes}.");
                        Console.WriteLine($"Adultos: {adultos}.");
                        Console.WriteLine($"Viejos: {viejos}.");

                        if (ninos > 0)
                            Console.WriteLine("Promedio del peso de los niños: " + (pesoninos / ninos));

                        if (jovenes > 0)
                            Console.WriteLine("Promedio del peso de los jovenes: " + (pesojovenes / jovenes));

                        if (adultos > 0)
                            Console.WriteLine("Promedio del peso de los adultos: " + (pesoadultos / adultos));

                        if (viejos > 0)
                            Console.WriteLine("Promedio del peso de los viejos: " + (pesoviejos / viejos));*/

            //8. El Departamento de Transito de Antioquia desea saber de los n autos que entran a la ciudad de Medellín, cuántos autos entran con calcomanía de un determinado color. Coonociendo el último dígito de la placa de cada automóvil se puede determinar el color de la calcomanía, para determinar lo anterior utilice la siguiente tabla: Digito 1 o 2 = amarilla ; Digito 3 o 4 = rosa ; Digito 5 o 6 = roja ; Digito 7 o 8 = verde ; Digito 9 o 0 = azul.
            //

/*            int n;
            int digito;
            int amarillas = 0;
            int rosas = 0;
            int rojas = 0;
            int verdes = 0;
            int azules = 0;

            Console.WriteLine("Ingrese la cantidad de carros. ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ingrese el último dígito de la placa del carro " + i + ": ");
                digito = int.Parse(Console.ReadLine());
                
                if (digito == 1|| digito == 2)
                {
                    amarillas++;
                }
                if (digito == 3|| digito == 4)
                {
                    rosas++;
                }
                if (digito == 5|| digito == 6)
                {
                    rojas++;
                }
                if (digito == 7|| digito == 8)
                {
                    verdes++;
                }
                if (digito == 9|| digito == 0)
                {
                    azules++;
                }
            }

            Console.WriteLine("Resultados: ");
            Console.WriteLine($"Calcomanías amarillas: {amarillas}.");
            Console.WriteLine($"Calcomanías rosas: {rosas}.");
            Console.WriteLine($"Calcomanías rojas: {rojas}.");
            Console.WriteLine($"Calcomanías verdes: {verdes}.");
            Console.WriteLine($"Calcomanías azules: {azules}.");*/

        }
    }

}

