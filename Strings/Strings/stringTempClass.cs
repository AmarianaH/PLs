using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    //Consider a better name for the class
    public class stringTempClass
    {
        //Consider a better name for this variable.
        //The convention in C# for private variables is to begin with "_". eg _temp
        public string temp;

        public stringTempClass(string temp)
        {
            this.temp = temp;
        }

        //Consider a better name from this.
        public int StringFunc()
        {
            //Consider a better name
            string sen = temp;

            //What about other white spaces chars and multiple of them?
            string[] senArray = sen.Split();
            Console.WriteLine($"the number of the words is : {senArray.Length} ");
            
            RevSen(senArray); // 2
            SortSen(senArray); //3

            return senArray.Length ;
        }

        //Consider a better name
        public string[] RevSen(string[] senArray)
        {
            string[] str = new string[senArray.Length];

            //The convention in C# is to start the "{" bracet at new line.
            //Consider the use of the Colnsole.Write overloading that accepts a format: Console.Write("{0} ", senArray[i]);
            //Or string.Format: Console.Write(string.Format("{0} ", senArray[i]);
            //Or even better, string interpolation: Console.Write($"{senArray[i]} ");
            //Also, why are you both printing and making a new array? Why just return the new array? That wuold have been better
            for (int i = senArray.Length - 1; i >= 0; i--) {
                Console.Write(senArray[i] + " ");
                str[senArray.Length-i-1] = senArray[i];
            }
            Console.WriteLine();
            //foreach (var i in str) Console.WriteLine(i);
            return str;
        }

        //Consider a better name
        //Same as RevSen
        public string[] SortSen(string[] senArray) {
            string[] str = new string[senArray.Length];
            Array.Sort(senArray);
            for(int i =0; i<senArray.Length;i++){
                Console.Write(senArray[i] + " ");
                str[i] = senArray[i];
            }
                Console.WriteLine();
            return str; 
        }

    }
}
