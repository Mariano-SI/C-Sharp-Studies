using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números: ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            double resultado = Maior(num1, num2, num3);

            Console.WriteLine("Maior = " + resultado);


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
