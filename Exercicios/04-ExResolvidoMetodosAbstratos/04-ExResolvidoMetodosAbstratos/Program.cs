using _04_ExResolvidoMetodosAbstratos.Entities;
using _04_ExResolvidoMetodosAbstratos.Entities.Enums;
using System.Globalization;

namespace _04_ExResolvidoMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List < Shape > shapesList = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or Cicle (r/c)");
                char shapeType = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color shapeColor = Enum.Parse<Color>(Console.ReadLine());

                if(shapeType == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapesList.Add(new Rectangle(shapeColor, width, heigth));
                }else if(shapeType == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapesList.Add(new Circle(shapeColor,radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape item in shapesList)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
