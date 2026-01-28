using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem8
    {
        public void SortDistinctCharactersWrapper()
        {
            string s = "tree";
            SortDistinctCharacters(s);
        }

        //TC - O(NLogN)  SC - O(N)
        private static void SortDistinctCharacters(string s)
        {
            char[] charArr = s.Distinct().ToArray();
            Array.Sort(charArr);
            Console.WriteLine("After sorting string with distinct characters:");
            foreach (var ele in charArr)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }
    }
}
