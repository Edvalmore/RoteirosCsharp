internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] vet = Console.ReadLine().Split(' ');
        int[] num = new int[n];


        int cont = 0;
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(vet[i]);
            if (num[i] % 2 == 0)
            {
                Console.Write(num[i] + " ");
                cont++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(cont);
    }
}