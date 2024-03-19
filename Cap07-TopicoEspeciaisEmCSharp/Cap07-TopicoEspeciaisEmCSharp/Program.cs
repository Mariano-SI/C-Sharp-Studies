using System.Globalization;

namespace Cap07_TopicoEspeciaisEmCSharp {
    internal class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Sintaxe inicial
            /*
            double desconto;
            if (preco < 20.0) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.05;
            }
            */

            //Sintaxe alternativa
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;


            Console.WriteLine(desconto);

        }
    }
}
