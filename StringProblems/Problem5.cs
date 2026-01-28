using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem5
    {
        public void IsomorphicStringWrapper()
        {
            string s = "egg";
            string t = "add";
            var res = IsomorphicString(s, t);
            Console.WriteLine($"{s} and {t} are isomorphic:{res}");
        }

        //TC - O(N)   SC - O(N)+O(N)
        private static bool IsomorphicString(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            // Use two dictionaries to ensure a unique one-to-one mapping
            Dictionary<char, char> mapST = new();
            Dictionary<char, char> mapTS = new();

            for (int i = 0; i < s.Length; i++)
            {
                char c1 = s[i];
                char c2 = t[i];

                // Check if s[i] has been mapped to something other than t[i]
                if (mapST.ContainsKey(c1) && mapST[c1] != c2) return false;

                // Check if t[i] has been mapped to something other than s[i]
                if (mapTS.ContainsKey(c2) && mapTS[c2] != c1) return false;

                // Establish the bidirectional mapping
                mapST[c1] = c2;
                mapTS[c2] = c1;
            }

            return true;
        }
    }
}
