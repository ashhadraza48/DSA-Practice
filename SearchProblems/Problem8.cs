using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem8
    {

        public void SearchNumberInRotatedArrayWrapper()
        {
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            int idx = SearchNumberInRotatedArray(arr, target);
            Console.WriteLine($"Index of target {target} is {idx}");
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int SearchNumberInRotatedArray(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[low] <= arr[mid])
                {
                    if (arr[low] <= target && target <= arr[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else
                {
                    if (arr[high] >= target && target >= arr[mid])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
            }
            return -1;

        }
    }
}
