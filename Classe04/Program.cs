using System;
using System.Globalization;

namespace Classe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            x.altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = x.altura * x.largura;
            System.Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            double perimetro = 2.0 * (x.altura + x.largura);
            System.Console.WriteLine("Perimetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            double diagonal = Math.Sqrt(Math.Pow(x.altura, 2) + Math.Pow(x.largura, 2));
            System.Console.WriteLine("Diagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Retangulo {
        public double largura;
        public double altura;
    }
}