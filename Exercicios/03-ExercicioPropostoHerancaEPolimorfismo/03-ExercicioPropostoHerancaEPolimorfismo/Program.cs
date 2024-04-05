using _03_ExercicioPropostoHerancaEPolimorfismo.Entities;
using System.Globalization;

namespace _03_ExercicioPropostoHerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int productsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= productsQuantity; i++)
            {
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (productType == 'i' || productType == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }else if(productType == 'u' || productType == 'U')
                {
                    Console.Write("Manufature date: ");
                    DateTime manufatureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufatureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
