using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem9
    {
        public void FindConsecutiveOnesWrapper()
        {
            int[] arr = { 0, 1, 1, 1, 0, 1 };
            FindConsecutiveOnes(arr);
        }
        private static void FindConsecutiveOnes(int[] arr)
        {

            int maxCount = 0, currentCount = 0;

            foreach (int num in arr)
            {
                if (num == 1)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 0;
                }
            }

            Console.WriteLine("Count of consecutive ones:"+maxCount);

        }

    }
}
