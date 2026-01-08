using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem32
    {
        public void MergeOverlappingSubIntervalsWrapper()
        {
            List<List<int>> arr = new List<List<int>>()
            {
                new List<int>(){1,5},
                new List<int>(){3,6},
                new List<int>(){8,10},
                new List<int>(){15,18}
            };

            MergeOverlappingSubIntervalsOptimal(arr);
        }


        //BruteForce  TC - O(NLogN) + O(2N)  Sc - O(N)
        private static void MergeOverlappingSubIntervalsBrute(List<List<int>> list)
        {
            list.Sort((a, b) => a[0].CompareTo(b[0]));
            List<List<int>> finalList = new();

            for (int i = 0; i < list.Count; i++)
            {
                int firstEle = list[i][0];
                int lastEle = list[i][1];

                if (finalList.Count != 0 && finalList[finalList.Count - 1][1] >= firstEle)
                    continue;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (lastEle >= list[j][0])
                    {
                        lastEle = Math.Max(lastEle, list[j][1]);
                    }
                    else
                    {
                        break;
                    }
                }
                finalList.Add(new List<int> { firstEle, lastEle });
            }

            foreach (var sublist in finalList)
            {
                foreach (var ele in sublist)
                {
                    Console.Write(ele + " ");
                }
                Console.WriteLine();
            }
        }



        //Optimal TC - O(NlogN) + O(N)  SC - O(N)
        private static void MergeOverlappingSubIntervalsOptimal(List<List<int>> list)
        {
            list.Sort((a, b) => a[0].CompareTo(b[0]));
            List<List<int>> finalList = new();

            for (int i = 0; i < list.Count; i++)
            {


                if (finalList.Count != 0 && finalList[finalList.Count - 1][1] >= list[i][0])
                {
                    finalList[finalList.Count - 1][1] = list[i][1];
                }
                else
                {
                    finalList.Add(list[i]);
                }
            }

            foreach (var sublist in finalList)
            {
                foreach (var ele in sublist)
                {
                    Console.Write(ele + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
