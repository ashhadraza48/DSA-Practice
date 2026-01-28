using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem12
    {
        public void LongestPalindromeStringWrapper()
        {
            string s = "abacc";
            var res = LongestPalindromeString(s);
            Console.WriteLine($"Longest Palindrome string is {res}.");
        }

        //TC - O(N)*O(N/2)  SC - O(1)
        private static string LongestPalindromeString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "Empty String.";

            int start = 0; int maxLength = 0;

            for (int i = 0; i < str.Length; i++)
            {
                //for Odd Length String
                Expand(str, i, i, ref start, ref maxLength);
                //for Even Length String
                Expand(str, i, i + 1, ref start, ref maxLength);
            }

            return str.Substring(start, maxLength);
        }

        private static void Expand(string str, int left, int right, ref int start, ref int maxLength)
        {
            while (left >= 0 && right < str.Length && str[left] == str[right])
            {
                int currLen = right - left + 1;

                if (currLen > maxLength)
                {
                    maxLength = currLen;
                    start = left;
                }

                left--;
                right++;
            }
        }
    }
}
