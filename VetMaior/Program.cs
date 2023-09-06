using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] vet = Console.ReadLine().Split(' ');
        double[] num = new double[n];
        
        for (int i = 0; i < n; i++) {
           num[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
        }

        double maior = 0;
        int posicao = 0;
        for (int i = 0; i<n; i++) {
            if(num[i] > num[0]){
                maior = num[i];
                posicao = i;
                if(maior < num[i-1]) {
                    maior = num[i-1];
                    posicao = i-1;
                }
            }
        }

        Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(posicao);
    }
}