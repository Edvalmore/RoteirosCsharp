using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < N; i++) {
                int num = int.Parse(Console.ReadLine());
                
                if (num == 0)
                    Console.WriteLine("NULL");
                    else 
                if (num > 0 && num %2 == 0)
                    Console.WriteLine("EVEN POSITIVE");
                    else
                if (num < 0 && num %2 == 0)
                    Console.WriteLine("EVEN NEGATIVE");
                    else
                if (num > 0 && num %2 != 0)
                    Console.WriteLine("ODD POSITIVE");
                    else
                    Console.WriteLine("ODD NEGATIVE");
            }
        }
    }
}