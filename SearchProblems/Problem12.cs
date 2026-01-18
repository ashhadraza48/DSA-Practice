using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem12
    {
        public void FindSingleNonDuplicateInSortedArrayWrapper()
        {
            int[] arr = { 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6 };
            var res = FindSingleNonDuplicateInSortedArray(arr);
            Console.WriteLine($"Single value in Array is {res}");
        }

        //LoopApproach  TC - O(logN)  SC - O(1)
        private static int FindSingleNonDuplicateInSortedArray(int[] arr)
        {
            int n = arr.Length;
            if (n == 1)
                return arr[0];

            int low = 1;
            int high = n - 2;

            if (arr[0] != arr[1])
                return arr[0];

            if (arr[n - 1] != arr[n - 2])
                return arr[n - 1];

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] != arr[mid - 1] && arr[mid] != arr[mid + 1])
                    return arr[mid];

                //Condition for elimintion.for left half,duplicate value will have index pair (even,odd)    
                if ((mid % 2 == 1 && arr[mid] == arr[mid - 1]) || (mid % 2 == 0 && arr[mid] == arr[mid + 1]))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }
            return -1;
        }
    }
}
