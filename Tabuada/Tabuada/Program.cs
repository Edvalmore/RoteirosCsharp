using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int multi;
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            multi = i * n;
            Console.WriteLine(i + " x " + n + " = " + multi);

        }
    }
}