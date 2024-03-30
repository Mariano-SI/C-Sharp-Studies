using System;
using System.Globalization;
using Cap09_EnumeracoesEComposicao.Entities;
using Cap09_EnumeracoesEComposicao.Entities.Enums;

namespace Cap09_EnumeracoesEComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maneiras de tentar fazer conversão de string para enumeração
            /*
                1 - OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
                2 - OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
                3 - OrderStatus os;
                     Enum.TryParse("Delivered", out os);
            */

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
