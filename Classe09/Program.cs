using System;
using System.Globalization;

namespace Classe09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria p;
            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            System.Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                System.Console.Write("Entre o valor do depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new ContaBancaria(num, nome, depInicial);
            }
            else
                p = new ContaBancaria(num, nome);

            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine(p);

            System.Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Depositar(valor);
            System.Console.Write("Dados da conta atualizado: ");
            Console.WriteLine(p);

            System.Console.Write("Entre um valor para saque: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Saque(quantia);
            System.Console.Write("Dados da conta atualizado: ");
            Console.WriteLine(p);
        }
    }
}
