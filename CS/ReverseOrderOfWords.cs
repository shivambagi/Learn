using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class ReverseOrderOfWords
    {
        public static string ReverseOrderOfWord(string inputString)
        {
            string reversedWordOrder = "";
            string[] charArray = inputString.Split(' ');

            for (int i = charArray.Length - 1; i >= 0; i--)
                reversedWordOrder += charArray[i] + " ";

            return reversedWordOrder;
        }
    }
}
