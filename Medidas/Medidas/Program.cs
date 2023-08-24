using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double altura, Base, area, perimetro, diagonal;

        Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = Base * altura;

        perimetro = 2 * (Base + altura);

        diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(altura, 2.0));

        Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);
    }
}