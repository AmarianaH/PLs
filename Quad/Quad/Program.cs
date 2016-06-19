using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quad
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            // Console.WriteLine($" 1 {t1} , 2 {t2} , 3 {t3} ");
            double a, b, c;
            Double.TryParse(t1 ,out a);
            Double.TryParse(t2, out b);
            Double.TryParse(t3, out c);

            var temp = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            if (a == 0) {
                //null
                Console.WriteLine("it's not a quadratic equation.");
                return;
            }
            if (Math.Pow(b, 2) - (4 * a * c) < 0) {
                //null
                Console.WriteLine("you have no solution for this equation. ");
                return;
            }
            
            var plus = (-b + temp) / (2 * a);
            var minus = (-b - temp) / (2 * a);

            if (temp == 0)
            {
                // one solution
                Console.WriteLine("You have one solution : ");
                Console.WriteLine($"x1 : {plus}");
            }
            else
            {
                Console.WriteLine($"x1 : {plus}");
                Console.WriteLine($"x2 : {minus}");
            }

        }
    }
}
