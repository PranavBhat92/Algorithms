using System;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 56,23,89,-12,99,0,-1,10};

            MergeSortAlgorithm(arr,0,arr.Length-1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }


        static void MergeSortAlgorithm(int[] arr,int p,int r)
        {
            if(r>p) {
                var q = (p + r) / 2;
                MergeSortAlgorithm(arr, p, q);
                MergeSortAlgorithm(arr, q + 1, r);
                Merge(arr,p,q,r);
            }
        }


        static void Merge(int[] arr,int p,int q,int r) {
            // If we do int[q-p] instead of int[q-p+1] then we are only subtracting the indexes. To include the qth element, we need to add 1 to q-p.
            int[] lowHalf = new int[q-p+1];
            int[] highHalf = new int[r-q];

            int i;
            int j;
            int k = p;

            for (i = 0; k <= q; i++,k++) {
                lowHalf[i] = arr[k];
            }

            for (j = 0; k <= r; j++,k++)
            {
                highHalf[j] = arr[k];
            }

            i = 0;
            j = 0;
            k = p;

            while (i <= (q-p) && j <= (r-q-1) && k <= r)
            {
                if (lowHalf[i] < highHalf[j])
                {
                    arr[k++] = lowHalf[i++];
                }
                else
                {
                    arr[k++] = highHalf[j++];
                }
            }

            while (k <= r && i <= (q - p))
            {
                arr[k++] = lowHalf[i++];
            }

            while (k <= r && j <= (r - q - 1))
            {
                arr[k++] = highHalf[j++];
            }
        }

    }
}
