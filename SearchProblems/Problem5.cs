using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem5
    {
        public void FloorAndCeilValueWrapper()
        {
            int[] arr = { 3, 4, 4, 7, 8, 10 };
            int target = 9;
            int res1 = arr.Length;
            var floorVal = FloorValueUsingLoop(arr, target);
            //var floorVal = FloorValueUsingRecursion(arr,0,arr.Length-1,target,res1);
            floorVal = floorVal != arr.Length ? floorVal : -1;
            int res2 = arr.Length;
            var ceilVal = CeilingValueUsingLoop(arr, target);
            //var ceilVal = CeilingValueUsingRecursion(arr,0,arr.Length-1,target,res2);
            ceilVal = ceilVal != arr.Length ? ceilVal : -1;
            Console.WriteLine($"Floor Value : {floorVal},  Ceiling Value: {ceilVal}.");
        }

        #region LoopApproach
        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int FloorValueUsingLoop(int[] arr, int target)
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
                    res = arr[mid];
                    low = mid + 1;
                }
                else
                    high = mid - 1;
            }

            return res;
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int CeilingValueUsingLoop(int[] arr, int target)
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
                    res = arr[mid];
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }

            return res;
        }

        #endregion LoopApproach

        #region RecursiveApproach

        //RecursiveApproach  TC - O(logN)  Sc - O(1)
        private static int FloorValueUsingRecursion(int[] arr, int low, int high, int target, int res)
        {

            if (low > high)
                return res;

            int mid = (low + high) / 2;

            if (arr[mid] <= target)
            {
                res = arr[mid];
                return FloorValueUsingRecursion(arr, mid + 1, high, target, res);
            }
            else
                return FloorValueUsingRecursion(arr, low, mid - 1, target, res);
        }


        //RecursiveApproach  TC - O(logN)  Sc - O(1)
        private static int CeilingValueUsingRecursion(int[] arr, int low, int high, int target, int res)
        {

            if (low > high)
                return res;

            int mid = (low + high) / 2;

            if (arr[mid] >= target)
            {
                res = arr[mid];
                return CeilingValueUsingRecursion(arr, low, mid - 1, target, res);
            }
            else
                return CeilingValueUsingRecursion(arr, mid + 1, high, target, res);
        }

        #endregion RecursiveApproach

    }
}
