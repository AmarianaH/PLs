﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            do
            {
                Console.WriteLine("\n \n");
                Console.WriteLine("Please enter a sentence: ");
                temp = Console.ReadLine();
                if (temp.Equals(""))
                {
                    Console.WriteLine("You didn't write a sentence");
                    return;
                }
                stringTempClass stc = new stringTempClass(temp);
                stc.StringFunc();

            } while (!temp.Equals(""));
        }
    }
}
