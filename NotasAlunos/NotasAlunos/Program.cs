using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double nota1, nota2, soma;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        soma = nota1 + nota2;

        if (soma > 60.00) {
            Console.WriteLine("NOTA FINAL = " + soma);
        } else
        {
            Console.WriteLine("NOTA FINAL = " + soma);
            Console.WriteLine("REPROVADO");
        }

    }
}