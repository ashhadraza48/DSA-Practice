using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem1
    {
        public void BinarySearchWrapper()
        {
            int[] arr = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            var res = BinarySearchUsingRecursion(arr, 0, arr.Length - 1, target);
            Console.WriteLine(res);
        }

        //Loop  TC - O(logn)  SC - O(1)  
        private static string BinarySearchUsingLoop(int[] arr, int target)
        {
            int n = arr.Length;
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return $"target {target} found at index {mid}.";
                else if (arr[mid] > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return $"target {target} not found.";
        }

        //Recursion  TC - O(logn) SC - O(1)
        private static string BinarySearchUsingRecursion(int[] arr, int low, int high, int target)
        {
            if (low > high)
                return $"target {target} not found.";

            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return $"target {target} found at index {mid}.";
            else if (arr[mid] > target)
                return BinarySearchUsingRecursion(arr, low, mid - 1, target);
            else
                return BinarySearchUsingRecursion(arr, mid + 1, high, target);
        }

    }
}
