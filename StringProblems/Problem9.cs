using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem9
    {
        public void MaxDepthOfParenthesisWrapper()
        {
            string s = "(1+(2*3)+((8)/4))+1";
            var res = MaxDepthOfParenthesis(s);
            Console.WriteLine($"Maximim depth of parenthesis in string {s} is {res}.");
        }

        //TC - O(N)  SC - O(1)
        private static int MaxDepthOfParenthesis(string str)
        {
            int currCount = 0;
            int maxCount = 0;

            foreach (var ch in str)
            {
                if (ch == '(')
                {
                    currCount++;
                    maxCount = Math.Max(maxCount, currCount);
                }
                else if (ch == ')')
                {
                    currCount--;
                }
            }
            return maxCount;
        }

    }
}
