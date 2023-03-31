using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinNumber
{
    class MaxMinNumber
    {
        static void Main(string[] args)
        {
            //Find maximum and minimum number 
            int[] arr1 = { 10,15,45,55,65,85,99,56,12,1,78,88};
            int max = arr1[0];
            int min = arr1[0];
            for(int i = 0; i <= arr1.Length - 1; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
        }
    }

    //output: min-1, max-99
}
