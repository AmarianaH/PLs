using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //usually in C# we declare each variable at a seperate line.
            //Also, please consider using better names for your variables..
            string t1, t2;
            double result = 0;
            Console.WriteLine("Please enter the first number : ");
            t1 = Console.ReadLine();
            double a = double.Parse(t1);

            Console.WriteLine("Please enter the second number ");
            t2 = Console.ReadLine();
            double b = double.Parse(t2);

            Console.WriteLine("Please enter the operator: {+-*/");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    result = a + b; break;

                case "-":
                    result = a - b; break;

                case "*":
                    result = a * b; break;

                case "/":
                    try { result = a / b; break; }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }

                default: Console.WriteLine("You didn't enter a logical operation.");
                    break;
            }

            Console.WriteLine($"Your result is : {result}");
        }
    }
}
