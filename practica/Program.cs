using System;
using System.Diagnostics;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            int opcion = 1;
            while (opcion != 0)
            {
                int numero;
                Console.WriteLine("Calculemos el factorial de un numero entero. Ingresalo");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Inserta un número válido");
                }

                Console.WriteLine("Si deseas repetir el programa inserta '1', si deseas acabar, inserta '0'");
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion != 1 && opcion != 0)
                {
                    Console.WriteLine("Inserta un número valido y dentro del rango indicado.");
                }

                Factorial(numero);



            }

            static int Factorial(int numero)
            {
                int i = 1;
                int resultado = 1;
                do
                {
                    resultado *= i;
                    i++;
                } while (i <= numero);

                return resultado;
            

            }


        }

    }
}