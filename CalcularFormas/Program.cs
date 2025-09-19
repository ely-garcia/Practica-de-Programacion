using System;

class Program
{
    // Función para calcular área de un rectángulo
    public static double AreaRectangulo(double baseR, double alturaR)
    {
        return baseR * alturaR;
    }

    // Función para calcular área de un círculo
    public static double AreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    // Función para calcular área de un trapecio
    public static double AreaTrapecio(double baseMayor, double baseMenor, double altura)
    {
        return ((baseMayor + baseMenor) * altura) / 2;
    }

    public static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== MENÚ DE ÁREAS ===");
            Console.WriteLine("1. Área de un Rectángulo");
            Console.WriteLine("2. Área de un Círculo");
            Console.WriteLine("3. Área de un Trapecio");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la base del rectángulo: ");
                    double baseR = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    double alturaR = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del rectángulo es: " + AreaRectangulo(baseR, alturaR));
                    break;

                case 2:
                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del círculo es: " + AreaCirculo(radio));
                    break;

                case 3:
                    Console.Write("Ingrese la base mayor del trapecio: ");
                    double baseMayor = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la base menor del trapecio: ");
                    double baseMenor = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del trapecio: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del trapecio es: " + AreaTrapecio(baseMayor, baseMenor, altura));
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }
}