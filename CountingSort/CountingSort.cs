using System;

namespace CountingSort
{
    class CountingSort
    {
        static void Main(string[] args)
        {
            //int[] arr = { 56, 23, 89, 12, 99, 1, 0, 10 };
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            CountingSortAlgorithm(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void CountingSortAlgorithm(int[] arr) {            
            int[] count = new int[1000];
            var outArr = new int[arr.Length];

            for (int j = 0; j < arr.Length; j++)
            {
                count[arr[j]]++;
            }

            for (int k = 1; k < count.Length; k++)
            {
                count[k] += count[k-1];
            }

            for (int l = 0; l < arr.Length; l++)
            {
                outArr[count[arr[l]] - 1] = arr[l];
                count[arr[l]]--;
            }

            for (int m = 0; m < arr.Length; m++)
            {
                arr[m] = outArr[m];
            }
        }
    }
}
