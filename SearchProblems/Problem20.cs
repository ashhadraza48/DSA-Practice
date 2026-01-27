using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem20
    {
        public void FindKthPositiveWrapper()
        {
            int[] arr = { 3, 5, 7, 10 };
            int k = 6;
            var res = FindKthPositive(arr, k);
            Console.WriteLine($"{k} Positive Number is {res}");
        }

        //TC - O(Log(sum(Arr)-max(arr)) * O(N)   SC - O(1)
        private static int FindKthPositive(int[] arr, int k)
        {
            int low = 0;
            int high = arr.Length - 1;
            int idx = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int missingCount = arr[mid] - (mid + 1);

                if (missingCount < k)
                {
                    idx = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }


            //Formula to calaculate arr[idx] + k - (arr[idx] - (idx+1))
            int num = (k + (idx + 1));
            return num;
        }

    }
}
