using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of stairs you want to take.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("____________________________");
            for (int i=1; i<=n; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write("$ ");
                }
                Console.WriteLine("");   
            }
            Console.WriteLine("____________________________");
        }
    }
}
