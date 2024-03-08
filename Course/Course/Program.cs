using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares voce vai comprar? ");
            double valorAsercomprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(cotacao, valorAsercomprado).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
