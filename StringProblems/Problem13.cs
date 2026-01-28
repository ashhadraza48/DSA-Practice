using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem13
    {
        public void BeautyValueWrapper()
        {
            string s = "aabcbaa";
            var res = BeautyValue(s);
            Console.WriteLine($"The beauty value of {s} is {res}.");
        }

        //TC - O(N^2)  SC - O(1)
        private static int BeautyValue(string str)
        {
            int n = str.Length;
            int totalbeauty = 0;

            for (int i = 0; i < n; i++)
            {
                int[] charCount = new int[26];

                for (int j = i; j < n; j++)
                {
                    charCount[str[j] - 'a']++;
                    totalbeauty += CalculateBeauty(charCount);
                }
            }
            return totalbeauty;
        }

        private static int CalculateBeauty(int[] charCount)
        {
            int maxVal = 0;
            int minVal = int.MaxValue;

            foreach (var val in charCount)
            {
                if (val > 0)
                {
                    maxVal = Math.Max(maxVal, val);
                    minVal = Math.Min(minVal, val);
                }
            }
            return maxVal - minVal;
        }
    }
}
