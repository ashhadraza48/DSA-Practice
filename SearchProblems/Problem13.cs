using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem13
    {
        public void FindPeakElementWrapper()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 5, 1 };
            var res = FindPeakElement(arr);
            Console.WriteLine($"Peak Element found at index :{res}");
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int FindPeakElement(int[] arr)
        {
            int n = arr.Length;
            if (n == 1)
                return arr[0];

            int low = 1;
            int high = n - 2;

            if (arr[0] > arr[1])
                return 0;

            if (arr[n - 1] > arr[n - 2])
                return n - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                    return mid;
                else if (arr[mid] > arr[mid - 1])
                    low = mid + 1;
                else
                    high = mid - 1; //this condition works for multiple peaks also

            }
            return -1;
        }
    }
}
