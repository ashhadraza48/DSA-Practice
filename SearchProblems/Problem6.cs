using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem6
    {
        public void FirstandLastOccurenceWrapper()
        {
            int[] arr = { 3, 4, 4, 4, 7, 8, 10 };
            int target = 4;
            int res1 = arr.Length;
            var first = FirstOccurrenceUsingLoop(arr, target);
            //var floorVal = FloorValueUsingRecursion(arr,0,arr.Length-1,target,res1);
            first = first != arr.Length ? first : -1;
            //int res2 = arr.Length;
            var last = LastOccurrenceUsingLoop(arr, target);
            //var ceilVal = CeilingValueUsingRecursion(arr,0,arr.Length-1,target,res2);
            last = last != arr.Length ? last : -1;
            Console.WriteLine($"First Occurrence index : {first},  Last Occurrence index: {last}.");

        }

        #region LoopApproach
        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int FirstOccurrenceUsingLoop(int[] arr, int target)
        {
            int n = arr.Length;
            int low = 0;
            int high = n - 1;
            int res = n;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] >= target)
                {
                    res = mid;
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }

            if (arr[res] != target)
                res = -1;

            return res;
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int LastOccurrenceUsingLoop(int[] arr, int target)
        {
            int n = arr.Length;
            int low = 0;
            int high = n - 1;
            int res = n;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] <= target)
                {
                    res = mid;
                    low = mid + 1;
                }
                else
                    high = mid - 1;
            }

            if (arr[res] != target)
                res = -1;

            return res;
        }

        #endregion LoopApproach

    }
}
