using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class MissingElement
    {
        static void Main()
        {

            //Find missing element in array
            int[] arr1 = {1,2,3,4,5,6,7,8 };
            int[] arr2 = { 1,2,3,5,6,7,8};
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i < arr1.Length - 1; i++)
            {
                sum1 = sum1 + arr1[i];
            }
            for(int j = 0; j < arr2.Length - 1; j++)
            {
                sum2 = sum2 + arr2[j];
            }
            Console.WriteLine("Missing Element: " + (sum1-sum2));
            

        }
    }

    //output=4
}
