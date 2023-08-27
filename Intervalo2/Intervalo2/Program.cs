using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num, contIn, contOut;
        int x = int.Parse(Console.ReadLine());
        contIn = 0;
        contOut = 0;

        for (int i = 0; i < x; i++)
        {
            num = int.Parse(Console.ReadLine());

            if (num >= 10 && num <= 20)
                contIn++;
            else 
                contOut++;
        }

        Console.WriteLine(contIn + " in");
        Console.WriteLine(contOut + " out");
    }
}