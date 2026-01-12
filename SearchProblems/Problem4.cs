using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem4
    {
        public void SearchInsertIdxWrapper()
        {
            int[] arr = { 1, 2, 3, 5 };
            int target = 4;
            // var res = SearchInsertIdxUsingLoop(arr,target);
            //Console.WriteLine(res);
            int ans = arr.Length;
            var res = SearchInsertIdxUsingRecursion(arr, 0, arr.Length - 1, target, ans);
            Console.WriteLine($"Index for {target} is {res}.");

        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static string SearchInsertIdxUsingLoop(int[] arr, int target)
        {
            int n = arr.Length;
            int low = 0;
            int high = n - 1;
            int idx = n;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] >= target)
                {
                    idx = mid;
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }

            return $"Index for {target} is {idx}.";
        }

        //RecursiveApproach  TC - O(logN)  Sc - O(1)
        private static int SearchInsertIdxUsingRecursion(int[] arr, int low, int high, int target, int idx)
        {

            if (low > high)
                return idx;

            int mid = (low + high) / 2;

            if (arr[mid] >= target)
            {
                idx = mid;
                return SearchInsertIdxUsingRecursion(arr, low, mid - 1, target, idx);
            }
            else
                return SearchInsertIdxUsingRecursion(arr, mid + 1, high, target, idx);
        }
    }
}
