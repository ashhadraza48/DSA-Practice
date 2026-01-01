using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem30
    {

        public void LargestSubArrayLengthWrapper()
        {
            int[] arr = { 15, -2, 2, -8, 1, 7, 10, 23 };
            LargestSubArrayLengthOptimal(arr);
        }

        //BruteForce  TC - O(N^2)  Sc - O(1)
        private static void LargestSubArrayLength(int[] arr)
        {
            int maxLen = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                int currLen = 0;
                int currSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    currSum += arr[j];
                    currLen += 1;

                    if (currSum == 0)
                    {
                        maxLen = Math.Max(currLen, maxLen);
                    }
                }
            }

            Console.WriteLine("Length of Largest Subarray:" + maxLen);
        }


        //Better TC - O(N) SC - O(N)
        private static void LargestSubArrayLengthOptimal(int[] arr)
        {
            int maxLen = 0;
            int sum = 0;
            Dictionary<int, int> sumIndexDict = new();//dictionary to store prefixsum and index

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (sum == 0)
                {
                    maxLen = i + 1;
                }
                else
                {
                    if (sumIndexDict.ContainsKey(sum))
                    {
                        maxLen = Math.Max(maxLen, i - sumIndexDict[sum]);
                    }
                    else
                    {
                        sumIndexDict[sum] = i;
                    }
                }
            }

            Console.WriteLine("Length of Largest Subarray:" + maxLen);
        }

    }
}
