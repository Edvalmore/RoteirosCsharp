internal class Program
{
    private static void Main(string[] args)
    {
        string[] num = Console.ReadLine().Split(' ');
        int m = int.Parse(num[0]);
        int n = int.Parse(num[1]);
        int[,] matriz = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            string[] ler = Console.ReadLine().Split(' ');   
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(ler[j]);
            }
        }

        for (int i=0; i<m; i++) {
            for (int j = 0; j<n; j++){
                Console.Write(matriz[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}