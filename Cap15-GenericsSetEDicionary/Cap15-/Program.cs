using Entities;
using System.Globalization;

namespace Cap15_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Produto(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Produto max = calculationService.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
