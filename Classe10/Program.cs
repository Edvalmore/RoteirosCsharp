using System;
using System.Globalization;

namespace Classe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBanc x;

            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            System.Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            System.Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's' || opcao == 'S')
            {
                System.Console.Write("Entre o valor de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new ContaBanc(num, nome, depInicial);
                System.Console.WriteLine("Dados da conta:");
                System.Console.WriteLine(x);
            }
            else
            {
                System.Console.WriteLine("Dados da conta:");
                x = new ContaBanc(num, nome);
                System.Console.WriteLine(x);
            }

            System.Console.Write("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Dados da conta atualizados:");
            x.Deposito(dep);
            System.Console.WriteLine(x);

            System.Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Dados da conta atualizados:");
            x.Saque(saque);
            System.Console.WriteLine(x);
        }
    }
}