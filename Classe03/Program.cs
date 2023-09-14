using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto item = new Produto();
        Console.WriteLine("Entre com os dados do produto:");
        System.Console.Write($"Nome: ");
        item.Nome = Console.ReadLine();
        System.Console.Write($"Preço: ");
        item.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write($"Quantidade no estoque: ");
        item.Quantidade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Dados do produto: " + item);

        System.Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        item.AddProdutos(qte);
        System.Console.WriteLine("Dados atualizados: " + item);

        System.Console.Write("Digite o número de produtos a ser removido ao estoque: ");
        qte = int.Parse(Console.ReadLine());
        item.RemoverProdutos(qte);
        System.Console.WriteLine("Dados atualizados: " + item);


    }


    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double Total() {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AddProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
    }
}