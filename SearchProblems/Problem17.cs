using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem17
    {
        public void MinimumDaysForMBouquetWrapper()
        {
            int[] arr = { 7, 7, 7, 7, 13, 11, 12, 7 };
            int m = 2;
            int k = 3;
            var res = MinimumDaysForMBouquet(arr, m, k);
            Console.WriteLine($"Minimum days required for {m} bouquet is {res}.");
        }

        //TC - O(log(max(arr)-min(arr))) * O(N)   SC - O(N)
        private static int MinimumDaysForMBouquet(int[] arr, int noOfBouquet, int noOfRose)
        {
            int low = arr.Min();
            int high = arr.Max();
            int ans = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (CheckBouquetPossible(arr, noOfBouquet, noOfRose, mid))
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

        private static bool CheckBouquetPossible(int[] arr, int noOfBouquet, int noOfRose, int days)
        {
            int count = 0;
            int totalBouquet = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= days)
                {
                    count += 1;
                }
                else
                {
                    totalBouquet += (count / noOfRose);
                    count = 0;
                }

            }
            totalBouquet += (count / noOfRose);

            if (totalBouquet >= noOfBouquet)
                return true;

            return false;

        }
    }
}
