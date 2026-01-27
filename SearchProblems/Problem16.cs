using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem16
    {
        public void MinimumRateToEatBananasWrapper()
        {
            int[] arr = { 7, 15, 6, 3 };
            var res = MinimumRateToEatBananas(arr, 8);
            Console.WriteLine($"Rate to Eat Banana:{res}");
        }

        //TC - O(LogN)*O(N)  SC - O(1)
        private static int MinimumRateToEatBananas(int[] arr, int hr)
        {
            if (arr.Length == hr)
            {
                return arr.Max();
            }
            else if (hr > arr.Length)
            {
                int low = 1;
                int high = arr.Max();

                while (low <= high)
                {
                    int mid = (low + high) / 2;

                    int takenHrs = CalculateHoursTaken(arr, mid);
                    if (takenHrs == hr)
                        return mid;
                    else if (takenHrs < hr)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

            }
            return -1;
        }

        private static int CalculateHoursTaken(int[] arr, int ratePerHr)
        {
            int totalHr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int hrsPerPile = (int)Math.Ceiling(arr[i] / (double)ratePerHr);
                totalHr += hrsPerPile;
            }
            return totalHr;
        }
    }
}
