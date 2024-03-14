using System.Globalization;

namespace Cap06_MemoriaArraysEListas {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];


            for (int i = 0; i < n; i++) {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product(name, price);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double averagePrice = sum / n;

            Console.WriteLine("Valor médio: " + averagePrice.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(vect);


        }
    }
}
