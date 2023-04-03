using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            int sum = 0;
            while (num != 0)
            {
                r = num % 10;  //4 ,3,2
                sum = sum * 10 + r; //4 ,433,432
                num = num / 10; //123,12, 1
            }
            Console.WriteLine("Reverse Number is {0}", sum);
        }
        //1234
        //Reverse Number is 4321
    }
}
