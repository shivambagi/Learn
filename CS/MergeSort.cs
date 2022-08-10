using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class MergeSort
    {
        static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }

        static void merge(int[] arr,int mid, int low, int high)
        {
            int i, j, k;
            int[] arrB = new int[arr.Length];
            i = low;
            j = mid + 1;
            k = low;

            while (i <= mid && j <= high)
            {
                if(arr[i] < arr[j])
                {
                    arrB[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    arrB[k] = arr[j];
                    j++;
                    k++;
                }
            }
            while(i <= mid)
            {
                arrB[k] = arr[i];
                i++;
                k++;
            }
            while (j <= high)
            {
                arrB[k] = arr[j];
                j++;
                k++;
            }
            for(i = low;i <= high; i++)
            {
                arr[i] = arrB[i];
            }
        }
        
        static void mergeSort(int[] arr,int low,int high)
        {
            int mid;
            if(low < high)
            {
                mid = (low + high) / 2;
                mergeSort(arr, low, mid);
                mergeSort(arr, mid + 1, high);
                merge(arr, mid, low, high);
            }
        }
        //static void Main(String[] args)
        //{
        //    int[] arr = { 64, 25, 12, 22, 11 };
        //    printArray(arr);
        //    Console.WriteLine("--------------------------");
        //    mergeSort(arr, 0, arr.Length - 1);
        //    printArray(arr);
        //    Console.ReadKey();
        //}
    }
}
