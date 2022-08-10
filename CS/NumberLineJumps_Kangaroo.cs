
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class NumberLineJumps_Kangaroo
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if ((v2 > v1 && x2 > x1) || (v2 < v1 && x2 < x1) || (v2 == v1 && x2 != x1) || (v2 != v1 && x2 == x1))
                return "NO";

            else
            {
                if (Math.Abs(x1 - x2) % Math.Abs(v1 - v2) == 0)
                {

                    return "YES";
                }
                else
                    return "NO";
            }
        }
    }
}
