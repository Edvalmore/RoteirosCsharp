using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int contA, contG, contD, num;
        num = int.Parse(Console.ReadLine());
        contA = 0;
        contG = 0;
        contD = 0;

        while (num != 4)
        {
            if ( num < 1 || num > 4)
            {
                num = int.Parse(Console.ReadLine());
            } else
            {
                switch (num)
                {
                    case 1: contA++;
                        break;
                    case 2: contG++; 
                        break;
                    case 3: contD++; 
                        break;
                }

                num = int.Parse(Console.ReadLine());

            }
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + contA);
        Console.WriteLine("Gasolina: " + contG);
        Console.WriteLine("Diesel: " + contD);
    }
}