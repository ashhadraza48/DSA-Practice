using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem7
    {
        public void CountOccurrenceWrapper()
        {
            int[] arr = { 1, 2, 2, 2, 5, 6 };
            int target = 2;
            int first = FirstOccurrence(arr, target);
            int last = LastOccurrence(arr, target);
            if (first != -1 || last != -1)
            {
                int totalCount = last - first + 1;
                Console.WriteLine($"Target {target} has total {totalCount} occurrence.");
            }
            else
            {
                Console.WriteLine($"target {target} has no Occurrence.");
            }
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int FirstOccurrence(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            int idx = arr.Length;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] >= target)
                {
                    idx = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (arr[idx] != target)
                idx = -1;

            return idx;
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int LastOccurrence(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            int idx = arr.Length;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] <= target)
                {
                    idx = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            if (arr[idx] != target)
                idx = -1;

            return idx;
        }

    }
}
