using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double valorTotal;

        string[] vet1 = Console.ReadLine().Split(' ');
        int peca1 = int.Parse(vet1[0]);
        int num1 = int.Parse(vet1[1]);
        double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

        string[] vet2 = Console.ReadLine().Split(' ');
        int peca2 = int.Parse(vet2[0]);
        int num2 = int.Parse(vet2[1]);
        double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

        valorTotal = (num1 * valor1) + (num2 * valor2);

        Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2"), CultureInfo.InvariantCulture);
    }
}