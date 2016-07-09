using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapeLib;
using System.Collections;

namespace ShapesApp1
{
    class ShapeManager
    {
        public ArrayList arr = new ArrayList();

        Circle c = new Circle(5, 5);
        ellipse e = new ellipse(2, 2);
        Rectangle r = new Rectangle(6, 7);

        public int Count {get
            {
                return arr.Count;
            } }


        public void func()
        {
            arr.Add(c);
            arr.Add(e);
            arr.Add(r);
        }
        public void Add(Shape s)
        {
            if (s != null)
                arr.Add(s);
        }

        public void DisplayAll()
        {
            foreach (Shape i in arr)
            {
                i.Display();
                Console.WriteLine($"the Area of the Shape is: {i.Area}");
            }
        }


        public Shape retByindex(int ind)
        {
            if (arr[ind] != null)
            {
                if (arr[ind] is Circle) return (Circle)arr[ind];
                if (arr[ind] is Rectangle) return (Rectangle)arr[ind];
                if (arr[ind] is ellipse) return (ellipse)arr[ind];
            }
            return null;
        }

        public void Save(StringBuilder sb)
        {
            foreach(IPersist i in arr)
            {
                i.Write(sb);
            }
        }
        
    }
}
