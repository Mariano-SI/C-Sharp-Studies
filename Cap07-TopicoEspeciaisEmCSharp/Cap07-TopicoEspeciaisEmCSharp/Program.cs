using System.Globalization;

namespace Cap07_TopicoEspeciaisEmCSharp {
    internal class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now; //data e hora de agora, no momento que fiz isso = 19/03/2024 07:47:55
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //datetime é do tipo valor e armazena Ticks é uma quantidae de nanosegundos que é convertida numa represetacao legivel

            //Outras formas de se declarar
            DateTime d2 = new DateTime(2024, 07, 05); //ano mes dia
            Console.WriteLine("Ano mes dia: " + d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); //ano mes dia hora minuto segundo
            Console.WriteLine("Ano mes dia e horario: " + d3);

            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500); //ano mes dia hora minuto segundo milissegundos
            Console.WriteLine(d4);

            //Declarando usando builders
            DateTime d5 = DateTime.Now; //data e hora atual no horario padrao da maquina
            DateTime d6 = DateTime.Today; //data de hoje no horario de 00:00:00
            DateTime d7 = DateTime.UtcNow; //data de hoje no horario universal de Greenwich

            //Usando parse
            DateTime d8 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:34");
            Console.WriteLine(d9);
            DateTime d10 = DateTime.Parse("15-08-2000"); //Formato brasileiro
            Console.WriteLine(d10);

        }
    }
}
