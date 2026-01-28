using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem3
    {
        public void LargestOddNumberInStringWrapper()
        {
            string s = "005347";
            LargestOddNumberInString(s);
        }

        //TC - O(N)  SC - O(1)
        private static void LargestOddNumberInString(string str)
        {

            int startIdx = 0;
            int endIdx = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                    startIdx++;
                else
                    break;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ((str[i] - '0') % 2 != 0)
                {
                    endIdx = i;
                    break;
                }
            }

            string res = "";
            if (startIdx < endIdx)
                res = str.Substring(startIdx, (endIdx - startIdx + 1));

            Console.WriteLine("Largest Odd number in string: "+res);
        }
    }
}
