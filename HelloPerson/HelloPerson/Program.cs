using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPerson
{
    //No input validation.
    class Program
    {
        static void Main(string[] args)
        {
            string name ;
            Console.WriteLine("Type Your Name Please : ");
            name = Console.ReadLine();

            //C# 6 feature. Nice. (String interpolation)
            Console.WriteLine($"Hello {name} , Welcome To My Project"); //ahleen
            Console.WriteLine("Please Enter Your Age: ");
            var temp = Console.ReadLine();

            //according to the C# convention, variables should start with a small letter.
            var Age = int.Parse(temp);
            Console.WriteLine("Here's a space for each year of your life :) : ");
            for(int i=0; i < Age; i++){
                for(int j=0; j < i; j++){
                    Console.Write(" ");
                }
                Console.Write($"{name}");
                Console.WriteLine();
            }
        }
    }
}
