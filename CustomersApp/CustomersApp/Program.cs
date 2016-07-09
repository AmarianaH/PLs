using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> custs = new List<Customer>();
        
            custs.Add(new Customer("Mariana", 100, "aa"));
            custs.Add(new Customer("maria", 101, "bb"));
            custs.Add(new Customer("mana", 102, "cc"));
            custs.Add(new Customer("mana", 103, "dd"));
            custs.Add(new Customer("mana", 103, "ee"));
            custs.Add(new Customer("mariana", 100, "ff"));
        
            foreach(Customer i in custs)
                Console.WriteLine($"{i.name,10}  {i.ID,10}");
            custs.Sort();

            Console.WriteLine();
            Console.WriteLine("Ther Customers list sorted by name only : ");
            foreach (Customer i in custs)
                Console.WriteLine($"{i.name,10}  {i.ID,10}");

        }
    }
}
