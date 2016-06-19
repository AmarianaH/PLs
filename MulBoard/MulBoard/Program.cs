using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] arr = new int[10,10]; 
            for(int i=0; i < 10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    arr[i, j] = (i+1) * (j+1);
                    Console.Write($" {arr[i,j]} \t ");
                }
                Console.WriteLine("");
            }
        }
    }
}
