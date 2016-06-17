using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1, 101);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"it's your {i+1} time ; guess what the number is.");
                string t = Console.ReadLine();
                int MyNum = int.Parse(t);
                if (MyNum > 100 || MyNum < 1)
                {
                    do
                    {
                        Console.WriteLine("wrong range, Take Another Chance");
                        t = Console.ReadLine();
                        MyNum = int.Parse(t);

                    } while (MyNum >= 100 && MyNum >= 1);
                }

                 
                if(MyNum.Equals(secret))
                {
                    Console.WriteLine($"{MyNum}, You Guessed what the number is, Congrats!! "); return;
                } else if(i==6)
                {
                    Console.WriteLine($"the number is {secret}, You didn't guess, try one more time.. ");
                }
            }
        }
    }
}