using System.Globalization;
using System;

internal class Area
{
    private static void Main(string[] args)
    {
        double area, precoTotal;

        Console.WriteLine("Informe as medidas de largura e comprimento do terreno:");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Informe o preço do metro quadrado do terreno");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = largura * comprimento;
        precoTotal = preco * area;

        Console.WriteLine("AREA = " +  area.ToString("F2"), CultureInfo.InvariantCulture);
        Console.WriteLine("PRECO = " + precoTotal.ToString("F2"), CultureInfo.InvariantCulture);

    }
}