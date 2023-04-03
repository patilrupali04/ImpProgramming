using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number4
{
    class ListOfPrimeNum
    {
        static void Main(string[] args)
        {
            //print the prime number from 7 to 70
            for(int i = 7; i <= 70; i++)
            {
                int num = i;
                int count = 0;
                for(int j = 1; j <= num; j++)
                {
                    if (num % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
