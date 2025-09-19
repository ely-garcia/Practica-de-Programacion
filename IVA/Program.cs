using System;

namespace EjercicioIva
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculemos el total a pagar de tus productos con 15% de IVA.");

            double precio;
            int cantidad;

            Console.WriteLine("Ingresa el precio unitario de tu producto");
            while (!double.TryParse(Console.ReadLine(), out precio))
            {
                Console.WriteLine("Número inválido. Por favor intentalo de nuevo");
            }

            Console.WriteLine("Ingresa la cantidad de productos que adquiriste (de ese tipo)");
            while (!int.TryParse(Console.ReadLine(), out cantidad))
            {
                Console.WriteLine("Número inválido. Por favor intentalo de nuevo");
            }

            Calculo(precio, cantidad);

        }

        static void Calculo(double x, int y)
        {
            double subtotal = x * y;
            double iva = subtotal * 0.15;
            double total = subtotal + iva;

            Console.WriteLine($"El subtotal a pagar es: {subtotal}");
            Console.WriteLine($"El iva del 15% sobre la compra es: {iva}");
            Console.WriteLine($"El total a pagar es: {total}");

        }

    }
}
