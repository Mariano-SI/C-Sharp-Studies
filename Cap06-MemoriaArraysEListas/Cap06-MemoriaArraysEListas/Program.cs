using System.Globalization;

namespace Cap06_MemoriaArraysEListas {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1} valor: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double mediaAltura = vect.Sum()/vect.Length;
            Console.WriteLine(mediaAltura);

        }
    }
}
