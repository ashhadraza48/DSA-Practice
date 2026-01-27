using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem22
    {
        public void FindMinOfMaxPagesAllocatedWrapper()
        {
            int[] arr = { 12, 34, 67, 90 };
            int k = 2;
            var res = FindMinOfMaxPagesAllocated(arr, k);
            Console.WriteLine($"Maximum pages allocated to each student is : {res}");
        }

        //TC - O(Log(sum(Arr)-max(arr)) * O(N)   SC - O(1)
        private static int FindMinOfMaxPagesAllocated(int[] arr, int noOfStud)
        {
            int low = arr.Max();
            int high = arr.Sum();
            int ans = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int studCount = CheckPagesAlllocationPossible(arr, noOfStud, mid);


                if (studCount <= noOfStud)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }

        private static int CheckPagesAlllocationPossible(int[] arr, int noOfStud, int noOfPages)
        {
            int studCount = 1;
            int sumOfPages = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] + sumOfPages <= noOfPages)
                {
                    sumOfPages += arr[i];
                }
                else
                {
                    studCount += 1;
                    sumOfPages = arr[i];
                }
            }

            return studCount;
        }
    }
}
