using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    class PalindromeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            int sum = 0;
            int temp = num;
            while (temp != 0)
            {
                r = temp % 10;
                sum = sum * 10 + r;
                temp = temp / 10;
            }
            Console.WriteLine("Reversed Number is: {0}", sum);
            if (sum == num)
            {
                Console.WriteLine("This is Palindrome number");
                /*5225
                      Reversed Number is: 5225
                     This is Palindrome number
                */
            }
            else
            {
                Console.WriteLine("This is not Palindrome");
                /*1234
                        Reversed Number is: 4321
                        This is not Palindrome
                 */
            }
        }
    }
}
