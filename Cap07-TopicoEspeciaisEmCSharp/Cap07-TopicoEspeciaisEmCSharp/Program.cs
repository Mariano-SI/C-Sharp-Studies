using System.Globalization;

namespace Cap07_TopicoEspeciaisEmCSharp {
    internal class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275); // 15/08/2001 13:45:58
            Console.WriteLine(d);

            //Propriedades
            Console.WriteLine("1) Date: " + d.Date); //apenas data, o horario fica zerado 15/08/2001 00:00:00
            Console.WriteLine("2) Day: " + d.Day); //apenas dia, 15
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); //dia da semana por extenso, no caso Wednesday
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear); //numero desse dia no ano, 227
            Console.WriteLine("5) Hour: " + d.Hour); // hora, 13
            Console.WriteLine("6) Kind: " + d.Kind); // Unspecified
            Console.WriteLine("7) Millisecond: " + d.Millisecond); // milissegundos,275
            Console.WriteLine("8) Minute: " + d.Minute); // minutos,45
            Console.WriteLine("9) Month: " + d.Month); // mes,8
            Console.WriteLine("10) Second: " + d.Second); // segundos,58
            Console.WriteLine("11) Second: " + d.Ticks); // contagem de 100 nanosegundos desde o dia 1 da era
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); // apenas horario completo 13:45:58.2750000
            Console.WriteLine("13) Year: " + d.Year); // ano, 2001

            Console.WriteLine("-------------------------------------------------------------------------------");
            //Formatação
            Console.WriteLine(d.ToLongDateString()); //quarta-feira, 15 de agosto de 2001
            Console.WriteLine(d.ToLongTimeString()); //13:45:58
            Console.WriteLine(d.ToShortDateString()); // 15/08/2001
            Console.WriteLine(d.ToShortTimeString()); // 13:45
            Console.WriteLine(d.ToString()); // 15/08/2001 13:45:58

            //formatando com mascara escolhida
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);

            Console.WriteLine("-------------------------------------------------------------------------------");
            //Operacoes com Datetime
            //Adicionando horas
            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d);
            Console.WriteLine(d2);

            //Adicionando minutos
            DateTime d3 = d.AddMinutes(10);
            Console.WriteLine(d);
            Console.WriteLine(d3);

            //Adicionando dias
            DateTime d4 = d.AddDays(10);
            Console.WriteLine(d);
            Console.WriteLine(d4); //util pra calcular datas de vencimentos por ex

            //Diferença entre datas
            DateTime dataInicial = new DateTime(2000, 10, 15);
            DateTime dataFinal = new DateTime(2000, 10, 18);

            TimeSpan t = dataFinal.Subtract(dataInicial);
            Console.WriteLine(t); //3.00:00:00, tres dias

        }
    }
}
