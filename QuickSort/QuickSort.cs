using System;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 56, 23, 89, -12, 99, 0, -1, 10 };

            QuickSortAlgorithm(arr,0,arr.Length-1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void QuickSortAlgorithm(int[] arr,int p,int r) {
            if (r-p > 0) {
                var q = Partition(arr,p,r);
                QuickSortAlgorithm(arr,p,q-1);
                QuickSortAlgorithm(arr,q+1,r);
            }
        }

        static int Partition(int[] arr,int p,int r){
            var pivot = arr[r];
            var j = p;
            for(int i=p; i < r; i++)
            {
                if(arr[i] < pivot)
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j++] = temp;
                }
            }
            arr[r] = arr[j];
            arr[j] = pivot;
            return j;
        }   

    }
}
