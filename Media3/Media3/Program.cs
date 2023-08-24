using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double media, mediaFinal;

        string[] vet = Console.ReadLine().Split(' ');
        double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
        double n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

        media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;
        if (media == 4.85)
            media = 4.8;

        if (media >= 7.0)
        {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno aprovado.");
        } else
        if (media < 5.0)
        {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno reprovado.");
        } else
        {
        
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");
            double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mediaFinal = (media + notaExame) / 2;
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
            Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}