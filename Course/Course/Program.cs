using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números inteiros você vai digitar: ");

            int n = int.Parse(Console.ReadLine());

            int somatorio = 0;

            for(int i = 1; i <= n; i++) {
                Console.Write("Valor #"+i+ ": ");
                somatorio += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma " + somatorio);

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
