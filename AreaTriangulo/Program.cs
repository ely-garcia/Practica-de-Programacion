using System;
class Calculo
{
    // Subprograma para calcular el área de un triángulo
    static double CalcularAreaTriangulo(double baseT, double altura)
    {
        return (baseT * altura) / 2;
    }

    static void Main()
    {
        double baseT;
        double altura;

        Console.WriteLine(" Cálculo del Área de un Triángulo ");

        // Pedir datos al usuario
        Console.Write("Ingrese la base del triángulo: ");
        while (!double.TryParse(Console.ReadLine(), out baseT))
        {
            Console.WriteLine("Número Inválido. Por favor intentalo de nuevo.");
        }
        
        Console.Write("Ingrese la altura del triángulo: ");
        while (!double.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Número Inválido. Por favor intentalo de nuevo.");
        }
        

        // Llamar al subprograma
            double area = CalcularAreaTriangulo(baseT, altura);

        // Mostrar resultado
        Console.WriteLine($"El área del triángulo es: {area}");
    }
}