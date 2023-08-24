using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double SalarioFixo, TotalVendas, TotalReceber;

        string nome = Console.ReadLine();
        SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        TotalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        TotalReceber = TotalVendas * 0.15 + SalarioFixo;

        Console.WriteLine("TOTAL = R$ " + TotalReceber.ToString("F2", CultureInfo.InvariantCulture));
    }
}