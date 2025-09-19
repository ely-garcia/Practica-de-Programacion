using System;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            int opcion; // Mover la declaración fuera del do-while
            do
            {
                int numero;
                Console.WriteLine("CALCULEMOS EL FACTORIAL DE UN NUMERO ENTERO");

                Console.WriteLine("Ingresa un número entero");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Dato inválido. Por favor intentalo de nuevo");
                }

                Calculo(numero);

                Console.WriteLine("Si deseas repetir el programa inserta 1, si deseas finalizar inserta 0.");
                while (!int.TryParse(Console.ReadLine(), out opcion) || (opcion != 0 && opcion != 1))
                {
                    Console.WriteLine("Dato inválido. Por favor intentalo de nuevo");
                }

            } while (opcion != 0);

            Console.WriteLine("Programa finalizado.");

        }

        static void Calculo(int x)
        {
            int resultado = 1;
            int i = 1;

            while (i <= x)
            {
                resultado *= i;
                i++;
            }

            Console.WriteLine($"El resultado del factorial del número ingresado es: {resultado}");
        }
    }
}