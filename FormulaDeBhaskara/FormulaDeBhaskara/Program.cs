using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double delta, r1, r2;

        string[] vet = Console.ReadLine().Split(' ');

        double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(B, 2.0) - 4 * A * C;

        if (A == 0 || delta < 0.0) {

            Console.WriteLine("Impossivel calcular");

        } else {
            r1 = (- B + Math.Sqrt(delta)) / (2.0 * A);
            r2 = (- B - Math.Sqrt(delta)) / (2.0 * A);

            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));

        }

    }
}