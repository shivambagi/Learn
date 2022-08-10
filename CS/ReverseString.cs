using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class ReverseString
    {
        public static string ReverseString3(string inputString)
        {
            string result = "";

            //StringBuilder sb = new StringBuilder();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];

                //sb.Append(inputString[i]);
            }

            return result;
        }
    }
}
