using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem9
    {
        public void SearchEleInRatatedArrayWithDuplicateWrapper()
        {
            int[] arr = { 7, 8, 1, 2, 3, 3, 3, 4, 5, 6 };
            int target = 10;
            bool res = SearchEleInRatatedArrayWithDuplicate(arr, target);
            Console.WriteLine($"Array has target {target} :{res}");
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static bool SearchEleInRatatedArrayWithDuplicate(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return true;

                if (arr[low] == arr[mid] && arr[mid] == arr[high])
                {
                    low = low + 1;
                    high = high - 1;
                    continue;
                }

                if (arr[mid] < target)
                {
                    if (arr[mid] <= arr[high] && target <= arr[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
                else
                {
                    if (arr[mid] >= arr[low] && target >= arr[low])
                        high = mid - 1;
                    else
                        low = low + 1;
                }
            }
            return false;
        }

    }
}
