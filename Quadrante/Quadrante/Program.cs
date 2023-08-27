using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] coord = Console.ReadLine().Split(' ');
        int x = int.Parse(coord[0]);
        int y = int.Parse(coord[1]);

        if (x == 0 || y == 0)
            Console.WriteLine("");
        else
        {
            while (x != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("quarto");
                else
                    Console.WriteLine("segundo");

                coord = Console.ReadLine().Split(' ');
                x = int.Parse(coord[0]);
                y = int.Parse(coord[1]);
            }
        }
    }
}