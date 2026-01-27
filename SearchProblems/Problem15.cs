using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class Problem15
    {
        public void FindNthRootOfNumberWrapper()
        {
            int num = 27;
            int nRoot = 3;
            var res = FindNthRootOfNumber(nRoot, num);
            Console.WriteLine($"{nRoot} Root of Number {num} is {res}. ");
        }

        //TC - O(LogN)  SC - O(1)
        private static int FindNthRootOfNumber(int nRoot, int num)
        {
            int low = 0;
            int high = num;
            int ans = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                long powVal = FindNthPower(nRoot, mid);//(long) Math.Pow(mid,nRoot);

                if (powVal == num)
                {
                    return mid;
                }
                else if (powVal < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }

        //Method to find Nth power of number
        private static long FindNthPower(int power, int num)
        {
            int b = num;
            int exp = power;
            long ans = 1;


            while (exp > 0)
            {
                if (exp % 2 == 1)
                {
                    exp--;
                    ans = ans * b;
                }
                else
                {
                    exp = exp / 2;
                    b = b * b;
                }
            }
            return ans;
        }

    }
}
