internal class Program
{
    private static void Main(string[] args)
    {
        string[] num = Console.ReadLine().Split(' ');
        int m = int.Parse(num[0]);
        int n = int.Parse(num[1]);
        int[,] matriz = new int[m,n];
        int soma=0;

        for (int i=0; i<m; i++) {
            string[] ler = Console.ReadLine().Split(' ');
            for (int j=0; j<n; j++) {
                matriz[i,j] = int.Parse(ler[j]);
            }
        }
    
        int[] tela = new int[m];
        for (int i=0; i<m; i++) {
            for (int j=0; j<n; j++){
                soma += matriz[i,j];
            }
            tela[i] = soma;
            soma=0;
        }

        for(int i=0; i<m; i++) {
            Console.WriteLine(tela[i]);
        }

    }
}