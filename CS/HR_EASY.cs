using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class HR_EASY
    {
        public static int pickingNumbers(List<int> a)
        {
            int[] arr = a.ToArray();
            Array.Sort(arr);
            int count = 0;
            int count_max = 0;
            for(int i = 0;i < arr.Length - 1;i++)
            {
                count = 0;
                for(int j = i+1;j < arr.Length;j++)
                {
                    if(Math.Abs(arr[i] - arr[j]) <= 1)
                    {
                        count++;
                    }
                }
                if(count > count_max)
                {
                    count_max = count;
                }
            }

            return count_max + 1;
        }

        public static List<int> permutationEquation(List<int> p)
        {
            List<int> final = new List<int>();
            int[] arr = p.ToArray();
            for (int i = 1; i <= arr.Length; i++)
            {
                int index1 = Array.IndexOf(arr, i) + 1;
                int index2 = Array.IndexOf(arr, index1) + 1;
                final.Add(index2);
            }

            return final;
        }

        public static int jumpingOnClouds(int[] c, int k)
        {

            int result = 100;
            for (int i = 0; i < c.Length; ++i)
            {
                if ((i + k) % k == 0)
                {
                    if (c[i] == 1)
                    {
                        result -= 3;
                    }
                    else
                    {
                        --result;
                    }
                }
            }
            return result;

        }

        public static string appendAndDelete(string s, string t, int k)
        {

            int i = 0;
            while (i < s.Length && i < t.Length)
            {
                if (s[i] == t[i]) i++;
                else break;
            }

            int remaining = s.Length - i;

            remaining += t.Length - i;

            if (remaining == k || (remaining <= k && remaining % 2 == k % 2) || s.Length + t.Length < k) return "Yes";

            return "No";
        }

        public static int squares(int a, int b)
        {
            double x = Math.Floor(Math.Sqrt(a));
            double y = Math.Floor(Math.Sqrt(b));
            int count = 0;

            while(x <= y)
            {
                if (x * x >= a && x * x <= b)
                {
                    count++;
                }
                x++;
            }
            
            return count;

        }
    }
}
