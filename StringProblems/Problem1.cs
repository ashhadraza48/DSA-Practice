using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem1
    {
        public void RemoveOuterParenthesisWrapper()
        {
            string s = "()(()())(())";
            RemoveOuterParentheses(s);
        }

        //TC - O(N) SC - O(1)
        private static void RemoveOuterParentheses(string str)
        {
            StringBuilder s = new StringBuilder();
            int idx = 0;

            foreach (char ch in str)
            {
                if (ch == '(')
                {
                    if (idx > 0)
                        s.Append(ch);
                    idx++;
                }
                else if (ch == ')')
                {
                    idx--;
                    if (idx > 0)
                        s.Append(ch);
                }
            }
            Console.WriteLine("string after removing outer parenthesis:" + s.ToString());
        }

    }
}
