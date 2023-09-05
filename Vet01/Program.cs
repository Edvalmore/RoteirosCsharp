using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] Num = new double[N];

        for (int i = 0; i < N; i++)
        {
            Num[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(Num[i].ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}