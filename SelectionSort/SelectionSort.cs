using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 32, 45, -11, 0, 2 };
            
            SelectionSortAlgorithm(arr, 5);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void SelectionSortAlgorithm(int[] A, int n)
        {
            for (var i = 0; i < n - 1; i++)
            {
                var keyIndex = i;
                for (var j = i + 1; j < n; j++)
                {
                    if (A[j] < A[keyIndex])
                    {
                        var temp = A[j];
                        A[j] = A[keyIndex];
                        A[keyIndex] = temp;
                    }
                }
            }
            return;
        }
    }
}
