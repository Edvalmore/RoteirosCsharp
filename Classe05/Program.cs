using System;
using System.Globalization;

namespace Classe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();
            Console.Write("Nome:");
            x.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + x);

            System.Console.Write("Digite a porcentagem para aumentar o salário:");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentarSalario(aumento);

            Console.WriteLine("Funcionário: " + x);

        }
    }

    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percent)
        {
            SalarioBruto += (SalarioBruto * percent / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}