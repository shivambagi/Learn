using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class BubbleSort
    {
        static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }

        static  void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            int temp;
            bool isSorted = true;
            for (int i = 0; i < n-1; i++)
            {
                for(int j = 0;j < n - i - 1; j++) // For no. of Passes
                {
                    if(arr[j] > arr[j + 1]) // For no. of comparisons in the passes
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    return;
                }
            }
        }

        //static void Main(String[] args)
        //{
        //    //int[] array = new int[] { 5, 9, 15, 7, 2 };
        //    int[] array = new int[] { 2, 9, 15, 21, 25 };

        //    printArray(array);
        //    bubbleSort(array);
        //    Console.WriteLine("------------------------");
        //    printArray(array);

        //    Console.ReadKey();
        //}
    }
}
