using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class FindCharacterWithMaxOccurences
    {
        public static char MaxOccurences(string inputstring)
        {
            int index = 0;
            int max = 0;
            int count = 0;
            char[] chararr = inputstring.ToLower().Distinct().ToArray();

            for(int i = 0;i < chararr.Length;i++)
            {
                count = 0;
                for(int j = 0;j < inputstring.Length;j++)
                {
                    if(chararr[i].ToString() == inputstring[j].ToString().ToLower())
                    {
                        count++;
                    }
                }
                if(count > max)
                {
                    max = count;
                    index = i;
                }
            }

            Console.WriteLine(max);
            return chararr[index];
        }

        public static void MaxOccurencesOfEachCharacter(string inputstring)
        {
            Console.WriteLine(DateTime.Now);
            char[] chararr = inputstring.Distinct().ToArray();
            int count = 0;
            foreach (var item in chararr)
            {
                count = 0;
                for(int i = 0;i < inputstring.Length;i++)
                {
                    if(item == inputstring[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(item + " " + count);
            }
            Console.WriteLine(DateTime.Now);

        }
    }
}
