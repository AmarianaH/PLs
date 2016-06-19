using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name ;
            Console.WriteLine("Type Your Name Please : ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name} , Welcome To My Project");
            Console.WriteLine("Please Enter Your Age: ");
            var temp = Console.ReadLine();
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
