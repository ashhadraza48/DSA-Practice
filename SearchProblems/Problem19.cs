using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem19
    {
        public void FindCapacityToShipPackageWrapper()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int days = 5;
            var res = FindCapacityToShipPackage(arr, days);
            Console.WriteLine("Capacity Required to Ship all package:" + res);
        }

        //TC - O(Log(sum(Arr)-max(arr)) * O(N)   SC - O(1)
        private static int FindCapacityToShipPackage(int[] arr, int days)
        {
            int low = arr.Max();
            int high = arr.Sum();
            int ans = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int RequiredDays = FindDaysToShipPackageWithCapacity(arr, mid);

                if (RequiredDays <= days)
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

        private static int FindDaysToShipPackageWithCapacity(int[] arr, int capacity)
        {
            int days = 1;
            int totalLoad = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (totalLoad + arr[i] > capacity)
                {
                    days += 1;
                    totalLoad = arr[i];
                }
                else
                {
                    totalLoad += arr[i];
                }
            }

            return days;
        }
    }
}
