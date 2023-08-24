using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double triangulo, circulo, trapezio, quadrado, retangulo;

        string[] vet = Console.ReadLine().Split(' ');
        double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        triangulo = A * C / 2.0;
        circulo = 3.14159 * Math.Pow(C, 2);
        trapezio = (A + B) / 2.0 * C;
        quadrado = Math.Pow(B, 2.0);
        retangulo = A * B;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

    }
}