using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int cont;
        double media, idade, soma;
        idade = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
        cont = 0;
        soma = 0.0;

        if (idade >= 0.0)
        {
            while (idade > 0.0)
            {
                cont++;
                soma += idade;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InstalledUICulture));
        }
        else
            Console.WriteLine("impossivel calcular");
    }
}