using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem18
    {
        public void SmallestDivisorWrapper()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int limit = 8;
            var res = SmallestDivisor(arr, limit);
            Console.WriteLine("smallest Divisor is:" + res);
        }

        //TC - O(Log(max(arr))) * O(N)  SC - O(1)
        private static int SmallestDivisor(int[] arr, int limit)
        {
            int low = 1;
            int high = arr.Max();
            int ans = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (CheckDivisorPossible(arr, limit, mid))
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

        private static bool CheckDivisorPossible(int[] arr, int limit, int divisor)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += (int)Math.Ceiling(arr[i] / (double)divisor);
            }

            if (sum <= limit)
                return true;

            return false;
        }
    }
}
