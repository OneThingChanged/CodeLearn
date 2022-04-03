using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Algorithm
{
    class Solution
    {
        static void swap(int[] arr, int a, int b)
        {
            int t = arr[a];
            arr[a] = arr[b];
            arr[b] = t;
        }

        /* This function takes last element as pivot, places
        the pivot element at its correct position in sorted
        array, and places all smaller (smaller than pivot)
        to left of pivot and all greater elements to right
        of pivot */
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // pivot
            int i = (low - 1); // Index of smaller element and indicates the right position of pivot found so far

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    i++; // increment index of smaller element
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        /* The main function that implements QuickSort
        arr[] --> Array to be sorted,
        low --> Starting index,
        high --> Ending index */
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[p] is now
                at right place */
                int pi = Partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
    }
}
