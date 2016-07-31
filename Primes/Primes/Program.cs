using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static int[] CalcPrimes(int x, int y)
        {
            //the new[]{0} is unnecessary. new ArrayList() is suffient.
            ArrayList arr = new ArrayList(new[]{0});
            
            for (int i = x; i <= y; i++)
            {
                bool isPrime = true; 

                //The convention in C# is to start the bracets in a new line.
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    arr.Add(i);
                }
            }
            //You can use arr.Count: new int[arr.Count]
            int[] tmp = new int[y-x];
            arr.CopyTo(tmp);
            return tmp;
        }

        static void Main(string[] args)
        {


            Console.WriteLine("please enter two numbers: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[] arr = Program.CalcPrimes(x, y);
            for(int i=0; i< arr.Length; i++)
            {
                if(arr[i]>0)
                Console.WriteLine($" {i} -- {arr[i]} is a prime number");
            }

        }

    }
}