using System;
using System.Globalization;

namespace Classe07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorMoeda x = new ConversorMoeda();
            Console.Write("Qual é a cotação do dólar? ");
            x.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantos dólares você vai cotar? ");
            x.Qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Valor a ser pago em reais = " + x.ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }


    class ConversorMoeda {
        public double Dolar;
        public double Qnt;
        public double ValorTotal() {
            return Dolar * Qnt * 0.06 + Dolar * Qnt;
        }

    }
}