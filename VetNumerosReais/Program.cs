using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double soma = 0.0;
        int n = int.Parse(Console.ReadLine());
        double[] vet = new double[n];
        string[] vet1 = Console.ReadLine().Split(' ');

        for (int i = 0; i<n; i++) {
            vet[i] = double.Parse(vet1[i], CultureInfo.InvariantCulture);
            soma += vet[i];
            Console.Write(vet[i].ToString("F1"), CultureInfo.InvariantCulture + " ");
        }
        Console.WriteLine();
        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        double media = 0.0;
        media = soma / n;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}