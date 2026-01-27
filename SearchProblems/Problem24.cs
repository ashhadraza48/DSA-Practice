using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem24
    {
        public void MinTimeToPaintBoardWrapper()
        {
            int[] arr = { 1, 10 };
            int noOfPainter = 2;
            int perUnitTime = 5;
            var res = MinTimeToPaintBoard(arr, noOfPainter, perUnitTime);
            Console.WriteLine($"Minimum time to paint board : {res}");
        }

        //TC - O(Log(sum(Arr)-max(arr)) * O(N)   SC - O(1)
        private static int MinTimeToPaintBoard(int[] arr, int noOfPainter, int perUnitTime)
        {
            int low = arr.Max();
            int high = arr.Sum();
            int ans = high;
            int mod = 10000003;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (CheckMinTimePossible(arr, noOfPainter, mid))
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return (int)((ans * perUnitTime) % mod);
        }

        public static bool CheckMinTimePossible(int[] arr, int noOfPainter, int minTime)
        {
            int painterCount = 1;
            int totalTime = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((totalTime + arr[i]) > minTime)
                {
                    painterCount += 1;
                    totalTime = arr[i];
                    if (painterCount > noOfPainter)
                        return false;
                }
                else
                {
                    totalTime += arr[i];
                }
            }
            return true;
        }
    }
}
