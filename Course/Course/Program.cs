using System.Drawing;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine(); 
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine("Dados do produto: "+ p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionaProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
