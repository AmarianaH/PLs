using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapeLib;
namespace ShapesApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager shM = new ShapeManager();
            Circle c1 = new Circle(1,1);
            ellipse e1 = new ellipse(1, 5);
            Rectangle r1 = new Rectangle(2, 7);

            shM.func();
            shM.Add(c1);
            shM.Add(e1);
            shM.Add(r1);
            shM.DisplayAll();
            
            StringBuilder sb = new StringBuilder();
            e1.Write(sb);
            r1.Write(sb);
            if (sb != null)
                shM.Save(sb);

            Console.WriteLine();
            Console.WriteLine("The stringBuilder text is : ");
            Console.WriteLine(sb);

            shM.arr.Sort();
            Console.WriteLine();
            Console.WriteLine("all the shapes sorted by their Area : ");
            shM.DisplayAll();
        }
    }
}
