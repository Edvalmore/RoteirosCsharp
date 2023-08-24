using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double distancia;

        string[] vet1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
        double y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

        vet1 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

        distancia = (double)Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }
}