using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class Binary_LinearSearch
    {
        public int linearSearch(int[] array, int size, int element)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }
            return 0;
        }
        public int binarySearch(int[] array, int size, int element)
        {
            int low = 0;
            int high = size - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (element == array[mid])
                {
                    return mid;
                }
                else if (element < array[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                }
            }

            return 0;
        }
    }
}
