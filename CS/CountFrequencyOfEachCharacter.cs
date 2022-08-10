using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class CountFrequencyOfEachCharacter
    {
		public static void FrequencyCount(int[] inputArray)
		{
			SortedDictionary<int, int> countDict = new SortedDictionary<int, int>();

			foreach (int item in inputArray)
			{
				if (!(countDict.ContainsKey(item)))
				{
					countDict.Add(item, 1);
				}
				else
				{
					countDict[item]++;
				}
			}

			foreach (var count in countDict)
			{
				Console.WriteLine(" {0} : {1} Times", count.Key, count.Value);
			}
		}
	}
}
