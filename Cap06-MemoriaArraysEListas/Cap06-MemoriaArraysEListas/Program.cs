using System.Globalization;

namespace Cap06_MemoriaArraysEListas {
    internal class Program {
        static void Main(string[] args) {


            string[] nomes = new string[] { "Mariano", "Maria", "Bob", "Alex" };

            //for normal

            for(int i = 0; i < nomes.Length; i++) {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine("------------------------------------------");

            //foreach
            foreach (string nome in nomes) {
                Console.WriteLine(nome);
            }
        }
    }
}
