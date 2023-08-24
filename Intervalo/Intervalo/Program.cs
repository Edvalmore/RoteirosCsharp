using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        double intervalo;

        intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(intervalo >= 0.0  && intervalo <= 25.0)
        {
            Console.WriteLine("Intervalo [0,25]");
        } else 
        if (intervalo > 25.0 && intervalo <= 50.0)
        {
            Console.WriteLine("Intervalo (25,50]");
        } else
        if (intervalo > 50.0 && intervalo <= 75.0)
        {
            Console.WriteLine("Intervalo (50,75]");
        } else
        if (intervalo > 75.0 && intervalo <= 100.0)
        {
            Console.WriteLine("Intervalo (75,100]");
        } else
        {
            Console.WriteLine("Fora de intervalo");
        }

    }
}