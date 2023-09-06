internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];

        string[] num = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            a[i] = int.Parse(num[i]);
        }

        num = Console.ReadLine().Split(' ');
        for (int i = 0; i<n; i++){
            b[i] = int.Parse(num[i]);
        }

        int[] c = new int[n];
        for (int i = 0; i<n; i++) {
            c[i] = a[i] + b[i];
            Console.Write(c[i] + " ");
        }
    }
}