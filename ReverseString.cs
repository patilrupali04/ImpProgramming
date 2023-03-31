using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            /* i/p: java
             o/p: avaj*/

            string str = "java";
            Console.WriteLine("Input string: {0}", str);

            char[] arr = str.ToCharArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
               
                Console.Write(arr[i]);  //Reverse string
            }



        }
    }
}
