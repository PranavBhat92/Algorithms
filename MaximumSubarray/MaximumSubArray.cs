using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubarray
{
    class MaximumSubArray
    {
        static void Main(string[] args)
        {
            /*
             input : 13,-3,-25,20,-3,-16,-23,18,20,-7,12,-5,-22,15,-4,7
             output: 18,20,-7,12
             */
            int[] arr = { 13,-3,-25,20,-3,-16,-23,18,20,-7,12,-5,-22,15,-4,7 };

            var result = MaximumSubArrayAlgorithm(arr,0,arr.Length-1);

            for (int i = result[0]; i <= result[1]; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();

        }

        static int[] MaximumSubArrayAlgorithm(int[] arr,int p,int r)
        {
            if (p == r)
            {
                return new int[] { p, r, arr[p] };
            }
            var q = (p + r) / 2;

            var LeftArray = MaximumSubArrayAlgorithm(arr,p,q);
            var rightArray = MaximumSubArrayAlgorithm(arr,(q+1),r);
            var crossArray = MaxCrossingArray(arr,p,q,r);

            if (LeftArray[2] >= rightArray[2] && LeftArray[2] >= crossArray[2])
            {
                return new int[] { LeftArray[0],LeftArray[1],LeftArray[2]};
            }
            else if(rightArray[2] >= LeftArray[2] && LeftArray[2] >= crossArray[2])
            {
                return new int[] { rightArray[0],rightArray[1],rightArray[2]};
            }
            else
            {
                return new int[] { crossArray[0],crossArray[1],crossArray[2]};
            }
        }

        static int[] MaxCrossingArray(int[] arr, int p, int q, int r)
        {
            var leftSum = -200; // should be < the lease integer in the array
            int maxLeft=-1;
            var sum = 0;

            for (int i = q; i > p; i--)
            {
                sum += arr[i];
                if (sum > leftSum) {
                    leftSum = sum;
                    maxLeft = i;
                }
            }

            var rightSum = -200;
            int maxRight=-1;
            sum = 0;

            for (int j =(q+1); j <= r; j++)
            {
                sum += arr[j];

                if (sum > rightSum) {
                    rightSum = sum;
                    maxRight = j;
                } 
            }

            return new int[] { maxLeft,maxRight,(leftSum+rightSum) };
        }
    }
}
