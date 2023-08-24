using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int HoraInicial, HoraFinal, HoraTotal;

        string[] vet = Console.ReadLine().Split(' ');
        HoraInicial = int.Parse(vet[0]);
        HoraFinal = int.Parse(vet[1]);

        if (HoraInicial < HoraFinal)
            HoraTotal = HoraFinal - HoraInicial;
        else
            HoraTotal = 24 - HoraInicial + HoraFinal;

        Console.WriteLine("O JOGO DUROU " + HoraTotal + " HORA(S)");

    }
}