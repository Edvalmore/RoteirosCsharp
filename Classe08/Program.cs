using System;
using System.Globalization;

namespace Classe08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Quantos dólares você vai comprar? ");
            double qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversaoMoeda.ValorTotal(dolar, qnt);
            System.Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class ConversaoMoeda {
        public static double ValorTotal(double dolar, double qnt){
            double total = dolar * qnt;
            return total + total * 0.06;
        }
    }
}