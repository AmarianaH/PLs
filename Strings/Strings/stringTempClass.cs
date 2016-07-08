using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class stringTempClass
    {
        public string temp;

        public stringTempClass(string temp)
        {
            this.temp = temp;
        }

        public int StringFunc()
        {
            string sen = temp;
            string[] senArray = sen.Split();
            Console.WriteLine($"the number of the words is : {senArray.Length} ");
            
            RevSen(senArray); // 2
            SortSen(senArray); //3

            return senArray.Length ;
        }


        public string[] RevSen(string[] senArray)
        {
            string[] str = new string[senArray.Length];
            for (int i = senArray.Length - 1; i >= 0; i--) {
                Console.Write(senArray[i] + " ");
                str[senArray.Length-i-1] = senArray[i];
            }
            Console.WriteLine();
            //foreach (var i in str) Console.WriteLine(i);
            return str;
        }

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
