using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int num, horasTrabalhadas;
        double valorPorHora, salario;

        num = int.Parse(Console.ReadLine());
        horasTrabalhadas = int.Parse(Console.ReadLine());
        valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = valorPorHora * horasTrabalhadas;

        Console.WriteLine("NUMBER = " + num);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2"), CultureInfo.InvariantCulture);
    }
}