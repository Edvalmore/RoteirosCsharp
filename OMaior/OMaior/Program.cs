using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int maiorAB, maior;

        string[] vet = Console.ReadLine().Split(' ');
        int n1 = int.Parse(vet[0]);
        int n2 = int.Parse(vet[1]);
        int n3 = int.Parse(vet[2]);

        maiorAB = (n1 + n2 + Math.Abs(n1 - n2)) / 2;
        maior = (maiorAB + n3 + Math.Abs(maiorAB - n3)) / 2;

        Console.WriteLine(maior + " eh o maior");
    }
}