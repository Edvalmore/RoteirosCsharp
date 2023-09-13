using System;
using System.Globalization;

namespace Classe02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            System.Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            System.Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.Salario + f2.Salario) / 2.0;

            System.Console.WriteLine($"Salário médio: {media:F2}");
        }
    }


    class Funcionario {
        public string Nome;
        public double Salario;
    }

}