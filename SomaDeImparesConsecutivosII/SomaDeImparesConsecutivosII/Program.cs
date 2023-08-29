using System;

internal class Program
{
    private static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            if (x > y)
            {
                int aux = x;
                x = y;
                y = aux;
            }

            int soma = 0;
            for (int j = x + 1; j < y; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }
            Console.WriteLine(soma);
        }
    }
}