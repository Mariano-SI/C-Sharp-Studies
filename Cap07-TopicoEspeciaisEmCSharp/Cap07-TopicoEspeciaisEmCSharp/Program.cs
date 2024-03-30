using System.Globalization;

namespace Cap07_TopicoEspeciaisEmCSharp {
    internal class Program {
        static void Main(string[] args) {

            /* É uma boa prática armazenar datas em horario UTC padrao Greenwich e exibir para o usuário fazendo uma conversao para o hirario local dele.*/

            DateTime dateExample1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dateExample2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dateExample3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + dateExample1);
            Console.WriteLine("d1 Kind: " + dateExample1.Kind);
            Console.WriteLine("d1 to Local: " +dateExample1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " +dateExample1.ToUniversalTime());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("d2: " + dateExample2);
            Console.WriteLine("d2 Kind: " + dateExample2.Kind);
            Console.WriteLine("d2 to Local: " +dateExample2.ToLocalTime());
            Console.WriteLine("d2 to UTC: " +dateExample2.ToUniversalTime());




        }
    }
}
