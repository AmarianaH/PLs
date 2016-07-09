using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeLib
{
    public class Circle : ellipse
    {
        double radius { get; set; }

       // public Circle(double radius)
       // {
       //     this.radius = radius;
       // }

        public Circle(double vertex, double covertex) : base(vertex, covertex)
        {
            radius = vertex;
        }

        public override double Area
        {
            get
            {
                return Math.PI * radius* radius;
            }
        }

        public override void Display()
        {
            Console.WriteLine($"the radius; distance from the center to a vertex; is :  {radius} ");
        }

    }
}
