using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int dn = 0;
            do {
                Console.WriteLine("Choose a number / or press -1 to exit");

                dn = int.Parse(Console.ReadLine());
                int originalDN = dn;
                int temp;
                string bn = null;

                while (dn > 0) {
                    temp = dn % 2;
                    dn /= 2;
                    bn = temp.ToString() + bn;
                }

                if(originalDN != -1) 
                    Console.WriteLine($"the Binary number for {originalDN} is: {bn}");

            } while (dn != -1);
        }
    }
}