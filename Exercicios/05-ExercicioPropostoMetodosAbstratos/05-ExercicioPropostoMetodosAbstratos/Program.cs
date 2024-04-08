using _05_ExercicioPropostoMetodosAbstratos.Enities;
using System.Globalization;

namespace _05_ExercicioPropostoMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char taxPayerType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(taxPayerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double helthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, helthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double totalTaxes = 0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
