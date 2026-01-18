using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem10
    {
        public void FindMinimumInRotatedArrayWrapper()
        {
            int[] arr = { 3, 8, 1, 2, 3, 3, 3, 3, 3, 3 };
            int res = FindMinimumInRotatedArray(arr);
            Console.WriteLine($"Minimum value in array : {res}");
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int FindMinimumInRotatedArray(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            int minVal = int.MaxValue;


            while (low <= high)
            {
                int mid = (low + high) / 2;

                // when selected array is sorted from starting index to ending index
                if (arr[low] < arr[mid] && arr[mid] < arr[high])
                {
                    minVal = Math.Min(minVal, arr[low]);
                    break;
                }

                //when array having duplicate values.
                if (arr[low] == arr[mid] && arr[mid] == arr[high])
                {
                    minVal = Math.Min(minVal, arr[low]);
                    low = low + 1;
                    high = high - 1;
                    continue;
                }

                if (arr[low] <= arr[mid])
                {
                    minVal = Math.Min(minVal, arr[low]);
                    low = mid + 1;
                }
                else
                {
                    minVal = Math.Min(minVal, arr[mid]);
                    high = mid - 1;
                }
            }
            return minVal;

        }

    }
}
