using System;

namespace Bubble_Sort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 56, 23, 89, 12, 99, 1, 0, 10 };
            BubbleSortAlgorithm(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void BubbleSortAlgorithm(int[] arr) {

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1]) {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }                                
            }
        }
    }
}
