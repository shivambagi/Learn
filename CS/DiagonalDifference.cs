using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int left = 0;
            int right = 0;
            int col = arr.Count - 1;
            for (int i = 0; i < arr.Count; i++, col--)
            {
                left += arr[i][i];
                right += arr[i][col];
            }
            return Math.Abs(left - right);
        }
    }
}
