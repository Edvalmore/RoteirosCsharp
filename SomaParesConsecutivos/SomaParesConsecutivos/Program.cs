using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int x, soma, cont;
        x = int.Parse(Console.ReadLine());
        soma = 0;

        while (x != 0)
        {
            if (x %2 == 0)
            {
                soma = x + (x + 2 + (x + 4 + (x + 6 + (x + 8))));
                Console.WriteLine(soma);
                x = int.Parse(Console.ReadLine());

            }
            else
            {
                soma = x + 1 + (x + 3 + (x + 5 + (x + 7 + (x + 9))));
                Console.WriteLine(soma);
                x = int.Parse(Console.ReadLine());
            }
        }

    }
}