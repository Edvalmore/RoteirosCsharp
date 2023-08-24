using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int segundosInt, horas, minutos, segundos;

        segundosInt = int.Parse(Console.ReadLine());

        horas = segundosInt / 3600;
        minutos = (segundosInt - horas * 3600) / 60;
        segundos = segundosInt - (horas * 3600 + minutos * 60);

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
    }
}