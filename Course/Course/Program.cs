using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {


            int age = 22;
            double saldo = 10.35784;
            string nome = "Mariano Carlos Silva";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, age, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {age} anos e tem saldo igaul a {saldo:F2} reais");

            //Concatenação
            Console.WriteLine(nome + " tem " + age + " anos e tem saldo igaul a " + saldo.ToString("F2") + " reais");
        }
    }
}
