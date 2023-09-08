internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int soma = 0;
        int[,] matriz = new int[num, num];

        for (int i = 0; i < num; i++)
        {
            string[] ler = Console.ReadLine().Split(' ');
            for (int j = 0; j < num; j++)
            {
                matriz[i, j] = int.Parse(ler[j]);
            }
        }

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine(soma);
            soma = 0;
        }
    }
}