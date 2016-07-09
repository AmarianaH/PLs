using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeLib 
{
    public class ellipse : Shape, IPersist, IComparable
    {
        double Vertex { get; set; }
        double coVertex { get; set; } 

        public override double Area
        {
            get
            {
                return Math.PI * Vertex * coVertex; 
            }
        }

        public ellipse(double vertex, double covertex)
        {
            this.Vertex = vertex;
            this.coVertex = covertex;
        }

        public override void Display()
        {
            Console.WriteLine($"the distance from the center to a vertex is : {Vertex} ");
            Console.WriteLine($"the distance from the center to a co-vertex is : {coVertex} ");
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine($"the Vertex is {Vertex} and the CoVertex is {coVertex} ");
        }

        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;
            var t = obj as Shape;
            if(t != null) return Area.CompareTo(t.Area);
            throw new ArgumentException("it's not a shape");

        }
    }
}
