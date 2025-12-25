using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem15
    {
        public void KadaneAlgorithmSubArraySumWrapper()
        {
            int[] arr = { 2, 3, 5, -2, 7, -4 };
            MaxSubArraySum(arr);
        }
        private static void MaxSubArraySum(int[] arr)
        {
            int currSum = arr[0];
            int maxSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currSum = Math.Max(arr[i], currSum + arr[i]);
                maxSum = Math.Max(currSum, maxSum);
            }

            Console.WriteLine("Largest Sum of SubArray:" + maxSum);
        }

        //Method to find Element
        private static void MaxSubArraySumELemnts(int[] arr)
        {
            int currSum = arr[0];
            int maxSum = arr[0];
            int startIdx = 0;
            int endIdx = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > (currSum + arr[i]))
                {
                    currSum = arr[i];
                    startIdx = i;
                }
                else
                {
                    currSum = currSum + arr[i];
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    //startIdx = currIdx;
                    endIdx = i;
                }
            }
            Console.WriteLine("Largest Array Index is from StartIndex: " + startIdx + " to EndIndex: " + endIdx);
            Console.WriteLine("Largest Sum of SubArray:" + maxSum);
        }

    }
}
