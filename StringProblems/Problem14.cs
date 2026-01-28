using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem14
    {
        public void IsIsogramWrapper()
        {
            string s = "abc";
            var res = IsIsogram(s);
            Console.WriteLine($"{s} is isogram:{res}.");
        }

        private static bool IsIsogramUsingLinq(string str)
        {
            // A string is an isogram if the count of distinct characters 
            // equals the length of the original string.
            return str.ToLower().Distinct().Count() == str.Length;
        }


        //TC - O(N)  SC - O(N)
        private static bool IsIsogram(string word)
        {
            var seen = new HashSet<char>();
            foreach (char c in word.ToLower())
            {
                if (char.IsWhiteSpace(c) || c == '-') continue;
                if (!seen.Add(c)) return false;
            }
            return true;
        }
    }
}
