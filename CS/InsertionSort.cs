using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class InsertionSort
    {
        static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void insertionSort(int[] arr)
        {
            int n = arr.Length;            
            for(int i = 1; i <= n - 1; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j>= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        //static void Main(String[] args)
        //{
        //    int[] array = new int[] { 5, 9, 15, 7, 2 };
        //    //int[] array = new int[] { 2, 9, 15, 21, 25 };

        //    printArray(array);
        //    insertionSort(array);
        //    Console.WriteLine("------------------------");
        //    printArray(array);

        //    Console.ReadKey();
        //}
    }
}
