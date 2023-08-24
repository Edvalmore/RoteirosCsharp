using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        string dia;

        x = int.Parse(Console.ReadLine());

        switch (x)
        {
            case 1:
                dia = "domingo";
                break;

            case 2:
                dia = "segunda";
                break;

            case 3:
                dia = "terça";
                break;

            case 4:
                dia = "quarta";
                break;

            case 5:
                dia = "quinta";
                break;

            case 6:
                dia = "sexta";
                break;

            case 7:
                dia = "sabado";
                break;

            default:
                dia = "codigo invalido";
                break;

        }

        Console.WriteLine("Dia da semana: " + dia);

    }
}