using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem21
    {
        public void LengthOfLongestSeqWrapper()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            LengthOfLongestConsecSeqOptimal(arr);
        }
        //BruteForce TC - O(N) + O(NLogN) SC - O(1)
        public static void LengthOfLongestConsecSeq(int[] arr)
        {
            Array.Sort(arr);
            int longestSeq = 1;
            int maxSeq = 1;
            int lastEle = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == (lastEle + 1))
                {
                    maxSeq += 1;
                    lastEle = arr[i];
                }
                else if (arr[i] != (lastEle + 1))
                {
                    longestSeq = Math.Max(maxSeq, longestSeq);
                    maxSeq = 1;
                    lastEle = arr[i];
                }
            }

            Console.WriteLine("Longest sequence:" + longestSeq);
        }

        //OptimalSolution TC - O(N) SC - O(1)
        private static void LengthOfLongestConsecSeqOptimal(int[] arr)
        {
            HashSet<int> numSet = new HashSet<int>(arr);
            int longestSeq = 1;
            int maxSeq = 0;

            foreach (var num in numSet)
            {
                int currEle = num;
                if (!numSet.Contains(num - 1))
                {
                    while (numSet.Contains(currEle))
                    {
                        maxSeq += 1;
                        currEle += 1;
                    }
                    longestSeq = Math.Max(maxSeq, longestSeq);
                    maxSeq = 0;
                }
            }

            Console.WriteLine("Longest sequence:" + longestSeq);
        }
    }
}
