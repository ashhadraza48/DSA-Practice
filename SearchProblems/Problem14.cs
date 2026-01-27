using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem14
    {
        public void FindSqrtOfNumberWrapper()
        {
            int num = 34;
            var res = FindSqrtOfNumber(num);
            Console.WriteLine($"Square Root of Number {num} is {res}. ");
        }

        //TC - O(LogN)  SC - O(1)
        private static int FindSqrtOfNumber(int num)
        {
            int low = 0;
            int high = num;
            int ans = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if ((mid * mid) <= num)
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
    }
}
