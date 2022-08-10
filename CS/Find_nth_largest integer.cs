using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Find_nth_largest_integer
    {
        public static void FindthirdLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            //incerease or decrese the max1,2,3 values and if-else conditions below
            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2 && i != max1)
                {
                    max3 = max2;
                    max2 = i;
                }
                else if (i > max3 && i != max2 && i != max1)
                {
                    max3 = i;
                }
            }
            Console.WriteLine(max3); ;
        }
    }
}
