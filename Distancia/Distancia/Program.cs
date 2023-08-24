using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        int tempo, km;

        km = int.Parse(Console.ReadLine());

        tempo = km * 2;

        Console.WriteLine(tempo + " minutos");

    }
}