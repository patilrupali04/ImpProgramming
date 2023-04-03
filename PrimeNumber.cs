using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Number is Prime {0}", num);
            }
            else
            {
                Console.WriteLine("Number is not Prime {0}", num);
            }

        }
    }
}
