using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int inicio, fim;
        int soma = 0;

        if (x < y)
        {
            inicio = x;
            fim = y;

        }
        else
        {
            inicio = y;
            fim = x;
        }

        for (int i = inicio + 1; i < fim; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}