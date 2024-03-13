using System.Drawing;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500, 10);

            //p.GetNome = "Mariano"; //nao consigo mais pois agora ele é privado
            p.Nome = "M";
            Console.WriteLine(p.Nome);
        }
    }
}
