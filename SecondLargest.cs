using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class SecondLargest
    {
        static void Main(string[] args)
        {
            int[] arr = {10,15,45,55,65,85,99,56,12,1,78,88 };
            int firstmax = arr[0];
            int secondmax = arr[0];
            for(int i = 0; i <= arr.Length-1; i++)
            {
                if (arr[i] > firstmax)
                {
                    secondmax = firstmax;
                    firstmax = arr[i];
                }
                else if (arr[i] > secondmax)
                {
                    secondmax = arr[i];
                }
            }
            Console.WriteLine("Largest: {0}", firstmax);
            Console.WriteLine("Second Largest: {0}", secondmax);

        }
    }
}
