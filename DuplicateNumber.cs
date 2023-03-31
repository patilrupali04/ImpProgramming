using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    class DuplicateNumber
    {
        static void Main(string[] args)
        {
            int[] arr1 = {20,45,10,33,5,40,33,9 };
            for(int i = 0; i <= arr1.Length - 1; i++)
            {
                for(int j=i+1; j <= arr1.Length - 1; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        Console.WriteLine("Duplicate:: {0}", arr1[i]);
                    }
                }
            }
        }
    }
}
