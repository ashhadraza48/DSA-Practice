using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem7
    {
        public void IsAnagramWrapper()
        {
            string s = "anagram"; 
            string t = "nagaram";
            var res = IsAnagram(s, t);
            Console.WriteLine($"{s} and {t} are Anagaram: {res}");
        }

        //Frequency Array  Approach TC - O(N) SC - O(1)
        private bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            // Use size 26 for lowercase 'a'-'z' or 256 for all ASCII
            int[] counter = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                counter[s[i] - 'a']++;
                counter[t[i] - 'a']--;
            }

            // If all counts are zero, they are anagrams
            foreach (int count in counter)
            {
                if (count != 0) return false;
            }

            return true;
        }



        //Sorting Approach TC - O(NlogN)+O(NlogN)   SC - O(N)+O(N) 
        private bool IsAnagramUsingSort(string s, string t)
        {
            if (s.Length != t.Length) return false;

            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            Array.Sort(sChars);
            Array.Sort(tChars);

            return new string(sChars) == new string(tChars);
        }



        //Linq Approach TC - O(N)  SC - O(N)
        private bool IsAnagramUsingLinq(string s, string t)
        {
            return s.Length == t.Length && s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
        }
    }
}
