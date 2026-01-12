using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem3
    {
        public void UpperBoundWrapper()
        {
            int[] arr = { 1, 2, 2, 4 };
            int target = 2;
            //var res = UpperBoundUsingLoop(arr,target);
            // Console.WriteLine(res);
            int ans = arr.Length;
            var res = UpperBoundUsingRecursion(arr, 0, arr.Length - 1, target, ans);
            Console.WriteLine($"Upper bound for {target} is {res}.");
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static string UpperBoundUsingLoop(int[] arr, int target)
        {
            int n = arr.Length;
            int low = 0;
            int high = n - 1;
            int res = n;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] > target)
                {
                    res = arr[mid];
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }

            return $"Upper bound for {target} is {res}.";
        }

        //RecursiveApproach  TC - O(logN)  Sc - O(1)
        private static int UpperBoundUsingRecursion(int[] arr, int low, int high, int target, int res)
        {

            if (low > high)
                return res;

            int mid = (low + high) / 2;

            if (arr[mid] > target)
            {
                res = arr[mid];
                return UpperBoundUsingRecursion(arr, low, mid - 1, target, res);
            }
            else
                return UpperBoundUsingRecursion(arr, mid + 1, high, target, res);
        }

    }
}
