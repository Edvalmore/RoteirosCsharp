using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int idade, ano, meses, dias, resto;

        idade = int.Parse(Console.ReadLine());

        ano = idade / 365;
        resto = idade % 365;
        meses = resto / 30;
        resto %= 30;
        dias = resto;

        Console.WriteLine(ano + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");

    }
}