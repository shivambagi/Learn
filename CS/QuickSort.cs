using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class QuickSort
    {
        static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }   
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low + 1;
            int j = high;
            int temp;

            do
            {
                while (arr[i] <= pivot && i < high)
                {
                    i++;
                }

                while (arr[j] > pivot && i >= 0)
                {
                    j--;
                }

                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            } while (i < j);

            // Swap A[low] and A[j]
            temp = arr[low];
            arr[low] = arr[j];
            arr[j] = temp;
            return j;
        }
        static void quickSort(int[] arr, int low, int high)
        {
            int partitionIndex; // Index of pivot after partition

            if (low < high)
            {
                partitionIndex = partition(arr, low, high);
                quickSort(arr, low, partitionIndex - 1);  // sort left subarray 
                quickSort(arr, partitionIndex + 1, high); // sort right subarray
            }
        }

        //static void Main(String[] args)
        //{
        //    int[] arr = { 64, 25, 12, 22, 11 };
        //    printArray(arr);
        //    Console.WriteLine("--------------------------");
        //    quickSort(arr, 0, arr.Length - 1);
        //    printArray(arr);
        //    Console.ReadKey();
        //}
    }
}
