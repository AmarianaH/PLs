using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeLib
{
    public class Rectangle : Shape, IPersist, IComparable
    {
        double width { get; set; } 
        double height { get; set; }

        public override double Area
        {
            get
            {
                return (width* height);
            }
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override void Display()
        {
            Console.WriteLine($"the height of the rectangle is: {height} ");
            Console.WriteLine($"the width of the rectangle is: {width} ");
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine($"the width is {width} and the height is {height} ");
        }

        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;
            var t = obj as Shape;
            if (t != null) return Area.CompareTo(t.Area);
            throw new ArgumentException("it's not a shape");
        }
    }
}
