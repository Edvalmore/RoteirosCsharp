using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int senha;
        senha = int.Parse(Console.ReadLine());

        while (senha != 2002)
        {
            Console.WriteLine("Senha Invalida");
            senha = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Acesso Permitido");
    }
}