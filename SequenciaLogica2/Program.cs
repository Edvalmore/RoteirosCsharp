using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int numLinha = int.Parse(vet[0]);
        int numMax = int.Parse(vet[1]);
        
        for (int i = 1; i <= numMax; i++)
        {
            Console.Write(i);

            if (i %numLinha == 0)
                Console.WriteLine();
                else
                Console.Write(" ");
        }
    }
}