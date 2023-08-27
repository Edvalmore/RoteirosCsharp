using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double media, idade, soma, cont;
        idade = int.Parse(Console.ReadLine());
        soma = 0;
        cont = 0;

        while (idade > 0)
        {
            soma += idade;
            cont++;
            idade = int.Parse(Console.ReadLine());
        }

        media = soma / cont;

        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}