using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeLib
{
    public abstract class Shape
    {
        ConsoleColor color;
        public abstract double Area { get; }

        public Shape(ConsoleColor color)
        {
            this.color = color;
        }
        public Shape()
        {
            this.color = ConsoleColor.White;
        }

        public virtual void Display()
        {
            Console.BackgroundColor = color;
        }

    }
}
