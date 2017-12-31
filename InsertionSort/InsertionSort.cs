using System;

namespace InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, -22, 10, 0, 3 };
            InsertionSortAlgorithm(arr, 5);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }


        static void InsertionSortAlgorithm(int[] A, int n) {
            for (int i = 1; i < n; i++)
            {
                var key = A[i];
                var j = i - 1;

                while (j>=0 && A[j]>key)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = key;
            }
        }
    }
}
