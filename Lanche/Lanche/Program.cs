using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int codigo, quantidade;
        double valor, total; 

        string[] vet = Console.ReadLine().Split(' ');
        codigo = int.Parse(vet[0]);
        quantidade = int.Parse(vet[1]);

        switch (codigo)
        {
            case 1:
                valor = 4.0;
                total = valor * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;
            
            case 2:
                valor = 4.5;
                total = valor * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;

            case 3:
                valor = 5.0;
                total = valor * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;

            case 4:
                valor = 2.0;
                total = valor * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;

            case 5:
                valor = 1.50;
                total = valor * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;

        }

    }
}