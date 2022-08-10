using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class _2D_to_1D_Array
    {
        public static void Convert(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            int[] arrs = new int[rows*columns];
            int index = 0;
            for(int i =0;i< rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    arrs[index] = arr[i, j];
                    index++;
                }
            }

            foreach (var item in arrs)
            {
                Console.WriteLine(item);
            }
        }

        

    }
}
