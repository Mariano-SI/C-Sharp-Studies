using System.Drawing;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Produto produtoExemplo = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produtoExemplo.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produtoExemplo.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produtoExemplo.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produtoExemplo.Nome}, ${produtoExemplo.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produtoExemplo.Quantidade} unidades, Total ${produtoExemplo.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produtoExemplo.AdicionaProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {produtoExemplo.Nome}, ${produtoExemplo.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produtoExemplo.Quantidade} unidades, Total ${produtoExemplo.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produtoExemplo.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados do produto: {produtoExemplo.Nome}, ${produtoExemplo.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produtoExemplo.Quantidade} unidades, Total ${produtoExemplo.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");


        }
        static int Maior(int n1, int n2, int n3) {
            if (n1 > n2 && n1 > n3) {
                return n1;
            }
            else if (n2 > n1 && n2 > n3) {
                return n2;
            }
            else {
                return n3;
            }
        }
    }
}
