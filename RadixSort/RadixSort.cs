using System;
using System.Linq;

namespace RadixSort
{
    class RadixSort
    {
        static void Main(string[] args)
        {
            //int[] arr = { 56, 23, 89, 12, 99, 1, 0, 10 };
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };

            RadixSortAlgorithm(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void RadixSortAlgorithm(int[] arr){

            var m = arr.Max();
            for (int e = 1; m/e > 0; e *= 10)
            {
                CountSort(arr,e);
            }
        }

        static void CountSort(int[] arr,int exp) {
            var count = new int[10];
            var outArr = new int[arr.Length];


            for (int i = 0; i < arr.Length; i++)
            {
                count[(arr[i]/exp)%10]++;
            }

            for (int j = 1; j < count.Length; j++)
            {
                count[j] += count[j-1];
            }

            // Must loop from arrlength-1 to 0 and not from 0 to arrlength-1
            for (int k = arr.Length - 1; k >= 0; k--)
            {
                outArr[count[(arr[k] / exp) % 10] - 1] = arr[k];
                count[(arr[k] / exp) % 10]--;
            }

            for (int l = 0; l < arr.Length; l++)
            {
                arr[l] = outArr[l];
            }
        }
    }
}
