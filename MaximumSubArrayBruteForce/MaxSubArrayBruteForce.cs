using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubArrayBruteForce
{
    class MaxSubArrayBruteForce
    {
        static void Main(string[] args)
        {
            /*
             input : 13,-3,-25,20,-3,-16,-23,18,20,-7,12,-5,-22,15,-4,7
             output: 18,20,-7,12, sum : 43
             */

            int[] arr = { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            MaximumSubArrayBruteForceAlgorithm(arr, 0, arr.Length - 1);
        }

        static void MaximumSubArrayBruteForceAlgorithm(int[] arr, int p, int r) {
            var maxSum = -200; // should be lesser than the least integer in the array
            int from = -1;
            int to = -1;

            for (int i = p; i<=(r-1); i++)
            {
                var sum = arr[i];
                for (int j = i+1; j<=r; j++)
                {
                    sum += arr[j];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        from = i;
                        to = j;
                    }
                }
            }

            Console.WriteLine("Sum :" + maxSum);
            Console.WriteLine("Series :");

            for (int k = from; k <= to; k++)
            {
                Console.WriteLine(arr[k]);
            }

            Console.ReadLine();
        }
    }
}
