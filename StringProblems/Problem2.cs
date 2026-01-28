using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem2
    {
        public void ReverseWordsWrapper()
        {
            string s = "welcome to the jungle";
            ReverseWords(s);
        }

        //TC -O(N)   SC - O(N)
        private static void ReverseWords(string str)
        {
            StringBuilder res = new();
            string[] words = str.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                res.Append(words[i]);
                if (i > 0)
                    res.Append(' ');
            }
            Console.WriteLine("Reversed strings: "+res.ToString());
        }


        //TC -O(N)  SC - O(N)
        private static void ReverseWordsWithCharacter(string str)
        {
            StringBuilder res = new();
            string[] words = str.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                char[] charArr = words[i].ToCharArray();
                Array.Reverse(charArr);
                res.Append(new string(charArr));
                if (i > 0)
                    res.Append(' ');
            }
            Console.WriteLine("Reversed strings with reversed characters: "+res.ToString());
        }

    }
}
