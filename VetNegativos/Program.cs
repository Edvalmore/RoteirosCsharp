using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];
        string[] vet1 = Console.ReadLine().Split(' ');

        for (int i = 0; i<n; i++) {
            vet[i] = int.Parse(vet1[i]);
        }

        for (int i = 0; i<n; i++) {
            if (vet[i] < 0)
                Console.WriteLine(vet[i]);
        }

    }
}

