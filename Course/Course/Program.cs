using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("uantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto:");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] infos = Console.ReadLine().Split(' ');
            string lastName = infos[0];
            int age = int.Parse(infos[1]);  
            double altura = double.Parse(infos[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(productPrice.ToString("F2"));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(altura);



        }
    }
}
