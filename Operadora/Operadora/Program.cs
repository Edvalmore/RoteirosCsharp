using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int minutos;
        double valor = 50.0;

        minutos = int.Parse(Console.ReadLine());

        if (minutos < 100)
        {
            Console.WriteLine("Valor a pagar: R$ 50.00");
        }
        else
        {
            valor += (minutos - 100.0) * 2.0;
            Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2"), CultureInfo.InvariantCulture);
        }

    }
}