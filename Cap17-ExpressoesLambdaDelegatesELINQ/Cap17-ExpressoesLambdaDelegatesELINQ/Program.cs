using Entities;
using System.Linq;
using System.Collections.Generic;


namespace Cap17_ExpressoesLambdaDelegatesELINQ
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1};
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1};

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product(){Id = 2, Name = "Hammer", Price = 90, Category = c1},
                new Product(){Id = 3, Name = "TV", Price = 1700, Category = c3},
                new Product(){Id = 4, Name = "Notebook", Price = 1300, Category = c2},
                new Product(){Id = 5, Name = "Saw", Price = 80, Category = c1},
                new Product(){Id = 6, Name = "Tablet", Price = 700, Category = c2},
                new Product(){Id = 7, Name = "Camera", Price = 700, Category = c3},
                new Product(){Id = 8, Name = "Printer", Price = 350, Category = c3},
                new Product(){Id = 9, Name = "MacBook", Price = 1800, Category = c2},
                new Product(){Id = 10, Name = "Sound Bar", Price = 700, Category = c3},
                new Product(){Id = 11, Name = "Level", Price = 70, Category = c1},
            };

            //TIER 1 AND PRICE < 900
            var result1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);

            Print("TIER 1 AND PRICE < 900", result1);

            //NAME OF PRODUCTS FROM TOOLS CATEGORY
            var result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);

            Print("NAME OF PRODUCTS FROM TOOLS CATEGORY", result2);

            //PRODUCTS THAT STARTS WITH C, BUT JUST SOME FIELDS(ANONYMOUS OBJECT)
            var result3 = products.Where(x => x.Name.ToUpper().StartsWith('C')).Select(x => new {x.Name, x.Price, CategoryName = x.Category.Name });

            Print("PRODUCTS THAT STARTS WITH C, BUT JUST SOME FIELDS(ANONYMOUS OBJECT)", result3);

            //PRODUCTS THAT CATEGORY TIER  = 1, ORDER BY PRICE ASC AND NAME 
            var result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            Print("PRODUCTS THAT CATEGORY TIER  = 1, ORDER BY PRICE ASC AND NAME", result4);

            //PAGINATION (THIS EXAMPLE USE ANOTHER RESULT AS DATA FONT)
            var result5 = result4.Skip(2).Take(4); //Pula os dois primeiros e pega 4

            Print("PAGINATION (THIS EXAMPLE USE ANOTHER RESULT AS DATA FONT)", result5);

            //SELECT BY POSITIONS
            var result6 = products.First();
            Console.WriteLine("First test1: " + result6);

            var result7 = products.Where(p => p.Price > 3000).FirstOrDefault(); // If you use First() in a empty collection an exception will be throw. Use FirstOrDefault in cases that you dont know if the result will be empty or not, because if the result be empty the expression returns null
            Console.WriteLine("FirstORDefault test2: " + result7);
            Console.WriteLine();

            var result8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SigleOrDefault test1: " + result8);


            var result9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SigleOrDefault test1: " + result9); //Result will be empty 

            //MAX PRICE
            var result10 = products.Max(p => p.Price);
            Console.WriteLine("MAX PRICE: "+ result10); //retuns 1800

            //MIN PRICE
            var result11 = products.Min(p => p.Price);
            Console.WriteLine("MIN PRICE: " + result11); //retuns 70

            //SUM OF PRICE OF PRODUTS FROM CATEGORY WITH ID 1
            var result12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("SUM OF PRICE OF PRODUTS FROM CATEGORY WITH ID 1: " + result12);

            //AVERAGE OF PRICE OF PRODUTS FROM CATEGORY WITH ID 1
            var result13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("AVERAGE OF PRICE OF PRODUTS FROM CATEGORY WITH ID 1: " + result13);

            //AGGREGATE == REDUCE IN JS
            var result14 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: "+ result14);

            var result15 = products.GroupBy(p => p.Category);

            foreach (IGrouping<Category, Product> group in result15)
            {
                Console.WriteLine("Category: " + group.Key.Name);
                foreach (Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }

        }
    }
}
