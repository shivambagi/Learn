using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class ClimbingTheLeaderboard
    {
        public void Method()
        {
            int[] _scores = new int[] { 100, 90, 90, 80, 75, 60 };
            int[] alice = new int[] { 50, 65, 77, 90, 102 };

            List<int> pos = new List<int>();
            int index = 0;
            List<int> scores = _scores.Reverse().Distinct().ToList();

            for (int i = 0; i < alice.Count(); i++)
            {
                for (int j = index; j < scores.Count(); j++)
                {
                    if (alice[i] < scores[j])
                    {
                        pos.Add(scores.Count() - j + 1);
                        index = j;
                        break;
                    }
                    else if (j == scores.Count() - 1)
                    {
                        pos.Add(scores.Count() - j);
                    }
                }
            }
            foreach (var item in pos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
