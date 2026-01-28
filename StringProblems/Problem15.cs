using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem15
    {
        public void ToCamelCaseWrapper()
        {
            string s = "abc-xyz";
            var res = ToCamelCase(s);
            Console.WriteLine($"The camel case of {s} is {res}.");
        }

        //TC - O(N) SC - O(1)
        private static string ToCamelCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            StringBuilder result = new StringBuilder(input.Length);
            bool nextUpper = false;
            bool firstWordFound = false;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) || c == '_' || c == '-')
                {
                    // Set flag to capitalize the next alphanumeric character
                    if (firstWordFound) nextUpper = true;
                }
                else if (char.IsLetterOrDigit(c))
                {
                    if (!firstWordFound)
                    {
                        // First letter of first word is always lowercase
                        result.Append(char.ToLower(c));
                        firstWordFound = true;
                    }
                    else if (nextUpper)
                    {
                        result.Append(char.ToUpper(c));
                        nextUpper = false;
                    }
                    else
                    {
                        result.Append(char.ToLower(c));
                    }
                }
            }
            return result.ToString();
        }

    }
}
