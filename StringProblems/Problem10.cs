using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem10
    {
        public void RomanToIntWrapper()
        {
            string s = "XC";
            var res = RomanToInt(s);
            Console.WriteLine($"Integer of Roman {s} is {res}.");
        }

        // TC - O(N)   SC - O(1)
        private static long RomanToInt(string str)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>(){
                {'I' , 1},
                {'V' , 5},
                {'X' , 10},
                {'L' , 50},
                {'C' , 100},
                {'D' , 500},
                {'M' , 1000}
            };

            long sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int currVal = romanMap[str[i]];

                // Check if there is a next character and if it's larger
                if (i + 1 < str.Length && romanMap[str[i + 1]] > currVal)
                {
                    sum -= currVal;
                }
                else
                {
                    sum += currVal;
                }
            }
            return sum;
        }


        #region IntegerToRoman
        // TC - O(N)   SC - O(1)
        public static string IntegerToRoman(int num)
        {
            StringBuilder str = new();

            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    str.Append(symbols[i]);
                }

                if (num == 0)
                    break;
            }

            return str.ToString();

        }

        #endregion IntegerToRoman

    }
}
