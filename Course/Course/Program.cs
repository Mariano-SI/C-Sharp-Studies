using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            double num = 0;

            while (num >= 0) {
                Console.Write("Digite um número:");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (num < 0) {
                    Console.WriteLine("Número negativo!");  
                }
                else {
                    double raiz = Math.Sqrt(num);
                    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                }
                
            }

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
