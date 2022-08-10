using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class SelectionSort
    {
        static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void selectionSort(int[] arr)
        {
            int min;
            int n = arr.Length;
            for(int i = 0; i < n-1; i++)
            {
                min = i;
                for(int j = i+1;j < n; j++)
                {
                    if(arr[j] < arr[min])
                    {                        
                        min = j;
                    }                    
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        //static void Main(String[] args)
        //{
        //    int[] arr = { 64, 25, 12, 22, 11 };
        //    printArray(arr);            
        //    Console.WriteLine("--------------------------");
        //    selectionSort(arr);
        //    printArray(arr);
        //    Console.ReadKey();
        //}
    }
}
