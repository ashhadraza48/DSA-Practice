using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem23
    {
        public void MinSumOfLargestSubArrayWrapper()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 3;
            var res = MinSumOfLargestSubArray(arr, k);
            Console.WriteLine($"Minimum sum of largest subarray : {res}");
        }

        //TC - O(Log(sum(Arr)-max(arr)) * O(N)   SC - O(1)
        private static int MinSumOfLargestSubArray(int[] arr, int k)
        {
            int low = arr.Max();
            int high = arr.Sum();
            int ans = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int count = CheckSumPossible(arr, mid);

                if (count <= k)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }

        private static int CheckSumPossible(int[] arr, int sum)
        {
            int currSum = 0; int subArrCount = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (currSum + arr[i] <= sum)
                {
                    currSum += arr[i];
                }
                else
                {
                    subArrCount += 1;
                    currSum = arr[i];
                }
            }
            return subArrCount;
        }
    }
}
