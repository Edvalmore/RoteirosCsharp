using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double salario, reajuste, novoSalario;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario <= 400.0)
        {
            reajuste = salario * 0.15;
            novoSalario = salario + reajuste;
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: 15 %");
        }
        else if (salario <= 800.0)
        {
            reajuste = salario * 0.12;
            novoSalario = salario + reajuste;
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: 12 %");
        }
        else if (salario <= 1200.0)
        {
            reajuste = salario * 0.1;
            novoSalario = salario + reajuste;
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: 10 %");
        }
        else if (salario <= 2000.01)
        {
            reajuste = salario * 0.07;
            novoSalario = salario + reajuste;
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: 7 %");
        }
        else if (salario >= 2000.01)
        {
            reajuste = salario * 0.04;
            novoSalario = salario + reajuste;
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: 4 %");
        }
    }
}