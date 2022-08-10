using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class BinarySearch
    {
        public static object BinarySearchDisplay(int[] arr, int target)
        {
            int low, high, mid;
            low = 0;
            high = arr.Length;
            mid = (low + high) / 2;
            while (low <= high)
            {
                if (arr[mid] == target)
                    return mid;
                else
                {
                    if (target < arr[mid])
                    { 
                        high = mid;
                    }
                    else
                    {
                        low = mid;
                        mid = (low + high) / 2;
                    }
                }
                    
            }
            return -1;
        }
    }
}
