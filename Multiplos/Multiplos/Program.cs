using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n1, n2;

        string[] vet = Console.ReadLine().Split(' ');
        n1 = int.Parse(vet[0]);
        n2 = int.Parse(vet[1]);

        if (n1 %n2 == 0 || n2 %n1 == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }

    }
}