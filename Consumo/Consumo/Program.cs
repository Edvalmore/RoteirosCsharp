using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int km;
        double litros, consumo;

        km = int.Parse(Console.ReadLine());
        litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        consumo = km /  litros;

        Console.WriteLine(consumo.ToString("F3") + " km/l", CultureInfo.InvariantCulture);
    }
}