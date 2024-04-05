using _04_ExResolvidoMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExResolvidoMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; private set; }

        public Shape()
        {
            
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
