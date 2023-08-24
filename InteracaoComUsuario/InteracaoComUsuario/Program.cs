using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Entre com seu nome completo:");
        string nome = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço de um produto:");
        double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
        string[] vet = Console.ReadLine().Split(' ');
        string ultimoNome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(produto.ToString("F2"), CultureInfo.InvariantCulture);
        Console.WriteLine(ultimoNome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);

    }
}