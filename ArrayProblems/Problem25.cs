using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem25
    {
        public void CountSubArraySumWrapper()
        {
            int[] arr = { 1, 1, 1 };
            int k = 2; //sum to find
            CountSubArraySum(arr,k);
        }

        //TC- O(N)  SC - O(N)
        private static void CountSubArraySum(int[] arr, int k)
        {
            // Dictionary to store (prefixSum, frequency)
            Dictionary<int, int> d = new Dictionary<int, int>();
            d[0] = 1; // Base case: a sum of 0 has occurred once

            int count = 0;
            int preSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                preSum += arr[i];
                int remain = preSum - k;

                // 1. Check if the required difference exists
                if (d.ContainsKey(remain))
                {
                    count += d[remain];
                }

                // 2. Update the frequency of the current prefix sum
                if (d.ContainsKey(preSum))
                {
                    d[preSum]++;
                }
                else
                {
                    d[preSum] = 1;
                }
            }

            Console.WriteLine("Total SubArray Count: " + count);
        }
    }
}
