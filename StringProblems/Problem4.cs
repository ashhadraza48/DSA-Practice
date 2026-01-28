using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem4
    {
        public void LongestCommonPrefixWrapper()
        {
            string[] arr = { "dog", "cat", "animal", "monkey" };
            LongestCommonPrefix(arr);
        }

        //TC - O(len(arr[0])) * O(N)  SC - O(1)
        private static void LongestCommonPrefix(string[] strArr)
        {
            int endIdx = 0;
            bool breakHappened = false;
            for (int i = 0; i < strArr[0].Length; i++)
            {
                char ch = strArr[0][i];

                for (int j = 1; j < strArr.Length; j++)
                {
                    if (i == strArr[j].Length || ch != strArr[j][i])
                    {
                        endIdx = i;
                        breakHappened = true;
                        break;
                    }
                }
                if (breakHappened)
                    break;

            }

            if (endIdx != 0)
                Console.WriteLine("Longest common Prefix in string: "+strArr[0].Substring(0, endIdx));
            else
                Console.WriteLine("No Matching");
        }
    }
}
