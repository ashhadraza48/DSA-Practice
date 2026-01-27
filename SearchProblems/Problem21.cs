using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem21
    {
        public void MaxOfMinDistanceBetweenTwoCowWrapper()
        {
            int[] arr = { 4, 2, 1, 3, 6 };
            int k = 2;
            var res = MaxOfMinDistanceBetweenTwoCow(arr, k);
            Console.WriteLine($"Maximum of Minimum distnace between two cow is {res}");
        }

        //TC - O(NlogN) + O(logN) * O(N)   SC - O(1)
        private static int MaxOfMinDistanceBetweenTwoCow(int[] arr, int noOfCow)
        {
            Array.Sort(arr);
            int low = 1;
            int high = arr.Max() - arr.Min();
            int ans = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;


                if (CheckMinDistancePossible(arr, noOfCow, mid))
                {
                    ans = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;


        }

        private static bool CheckMinDistancePossible(int[] arr, int noOfCow, int dist)
        {
            int cowCount = 1; int lastCow = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - lastCow >= dist)
                {
                    cowCount += 1;
                    lastCow = arr[i];
                }

                if (cowCount == noOfCow)
                    return true;
            }
            return false;
        }
    }
}
