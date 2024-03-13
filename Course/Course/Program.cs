using System.Drawing;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            int numero;
            string nomeTitular;
            double saldoInicial;
            char depositoInicial;
            ContaBancaria c1;
            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            nomeTitular = Console.ReadLine();

            Console.Write("Haverá valor de depósito inicial (s/n)? ");
            depositoInicial = char.Parse(Console.ReadLine());

            if(depositoInicial == 's') {
                Console.Write("Entre o valor do deposito inicial: ");
                saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(numero, nomeTitular, saldoInicial);
                
            }
            else {
                c1 = new ContaBancaria(numero, nomeTitular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);

        }
    }
}
