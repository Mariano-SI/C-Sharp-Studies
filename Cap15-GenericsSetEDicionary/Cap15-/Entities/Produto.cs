using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    internal class Produto: IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Produto))
            {
                throw new ArgumentException("Comparing error: argument is not a Produto");
            }

            Produto other = obj as Produto;
            return Price.CompareTo(other.Price);
        }
    }

    
}
