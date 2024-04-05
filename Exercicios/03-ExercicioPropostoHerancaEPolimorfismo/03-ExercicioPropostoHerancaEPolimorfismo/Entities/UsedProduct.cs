using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03_ExercicioPropostoHerancaEPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; private set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufatureDate): base(name, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufature date: {ManufatureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
