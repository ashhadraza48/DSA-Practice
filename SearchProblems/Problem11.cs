using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem11
    {
        public void FindKRotationInSortedArrayWrapper()
        {
            int[] arr = { 7, 8, 1, 2, 3, 3, 3, 4, 5, 6 };
            int res = FindKRotationInSortedArray(arr);
            Console.WriteLine($"Minimum value in array : {res}");
        }


        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int FindKRotationInSortedArray(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            int minVal = int.MaxValue;
            int idx = -1;


            while (low <= high)
            {
                int mid = (low + high) / 2;

                // when selected array is sorted from starting index to ending index
                if (arr[low] < arr[mid] && arr[mid] < high)
                {
                    if (arr[low] < minVal)
                    {
                        idx = low;
                        minVal = arr[low];
                    }
                    break;
                }

                //when array having duplicate values.
                if (arr[low] == arr[mid] && arr[mid] == arr[high])
                {
                    if (arr[low] < minVal)
                    {
                        idx = low;
                        minVal = arr[low];
                    }
                    low = low + 1;
                    high = high - 1;
                    continue;
                }

                if (arr[low] <= arr[mid])
                {
                    if (arr[low] < minVal)
                    {
                        idx = low;
                        minVal = arr[low];
                    }
                    low = mid + 1;
                }
                else
                {
                    if (arr[mid] < minVal)
                    {
                        idx = mid;
                        minVal = arr[mid];
                    }
                    high = mid - 1;
                }
            }
            return idx;

        }
    }
}
