using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        System.Console.WriteLine("Produtos:");
        System.Console.WriteLine($"{produto1}, cujo o preço é $ {preco1:F2}");
        System.Console.WriteLine($"{produto2}, cujo o preço é $ {preco2:F2}");

        System.Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");

        System.Console.WriteLine($"Medida com oito casas decimais: {medida}");
        System.Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
        System.Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3"), CultureInfo.InvariantCulture);

    }
}