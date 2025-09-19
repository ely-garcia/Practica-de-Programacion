using System;

namespace ParoImpar
{
    class Program
    {
        static void Main()
        {
            int numero;
            Console.WriteLine("COMPORBEMOS SI UN NÚMERO ES PAR O IMPAR.");

            Console.WriteLine("Inserta un número entero");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido. Por favor inténtalo de nuevo.");
            }

            Comprobar(numero);



        }

        static void Comprobar(int numero)
        {
            if (numero % 2 == 1)
            {
                Console.WriteLine("El número que ingresaste es impar.");
            }
            else
            {
                Console.WriteLine("El número que ingresaste es par.");
            }
        }


    }
}