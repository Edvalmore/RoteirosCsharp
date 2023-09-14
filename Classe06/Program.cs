using System;
using System.Globalization;

namespace Classe06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Nota final: " + x.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if(x.NotaFinal() > 60)
                Console.WriteLine("Aprovado");
                else {
                    Console.WriteLine("Reprovado");
                    Console.Write("Faltaram " + x.Pontos().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
                }
        }
    }

    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double Pontos() {
            return 60.0 - NotaFinal();
        }
    }
}