using System;

namespace Intercambio
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine("INTERCAMBIEMOS UN VALOR");
            Console.WriteLine($"Los valores actuales son: x={x} y y={y}");

            Intercambio(ref x, ref y);
            Console.WriteLine($"El valor intercambiado de las variables es: x={x} y y={y}");

        }

        static void Intercambio(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
    }
}