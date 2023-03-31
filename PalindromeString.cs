using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            string str = "level";
            Console.WriteLine("input string: {0}", str);
            char[] arr1 = str.ToCharArray();
            string rev = "";
            for (int i=arr1.Length-1;i>=0;i--)
            {
                rev = rev + arr1[i];
            }
            Console.WriteLine("Reversed: {0}", rev);

            if (str.Equals(rev))
            {
                Console.WriteLine(str + " Palindrome String");
            }
            else
            {
                Console.WriteLine(str + " Not Palindrome String");
            }
        }
    }
}
