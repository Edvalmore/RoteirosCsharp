using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int horas, kmPorHora;
        double litros;

        horas = int.Parse(Console.ReadLine());
        kmPorHora = int.Parse(Console.ReadLine());

        litros = (horas * kmPorHora) / 12.0;

        Console.WriteLine(litros.ToString("F3"), CultureInfo.InvariantCulture);
    }
}