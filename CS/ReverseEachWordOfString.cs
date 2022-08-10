using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class ReverseEachWordOfString
    {
		public static string ReverseWord(string inputString)
		{
			StringBuilder reversedWord = new StringBuilder();
			List<char> charList = new List<char>();

			for (int i = 0; i < inputString.Length; i++)
			{
				if (inputString[i] == ' ' || i == inputString.Length - 1)
				{
					if (i == inputString.Length - 1)
						charList.Add(inputString[i]);

					for (int j = charList.Count - 1; j >= 0; j--)
						reversedWord.Append(charList[j]);

					reversedWord.Append(' ');
					charList = new List<char>();
				}
				else
					charList.Add(inputString[i]);
			}

			return reversedWord.ToString();
		}
	}
}



//string[] s = "asdas ad add asd".Split(' ').ToArray();

//StringBuilder sb = new StringBuilder();

//for (int i = 0; i < s.Length; i++)
//{
//	for (int j = s[i].Length - 1; j >= 0; j--)
//	{
//		sb.Append(s[i][j]);
//	}
//	if (i != s.Length - 1)
//	{
//		sb.Append(" ");
//	}
//}