using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class FactorialNumber
    {
        static void Main(string[] args)
        {
            //5!=5*4*3*2*1

            Console.WriteLine("Please Enter A Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of Given Number {0} ", fact);
        }

        //5
        //Factorial of Given Number 120
    }
}
