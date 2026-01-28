using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem11
    {
        public void AtoiWrapper()
        {
            string s = "   -4193 with words";
            var res = Atoi(s);
            Console.WriteLine($"Atoi of {s} is {res}.");
        }

        //TC - O(N)  SC - O(1)
        private static int Atoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int i = 0;
            int n = str.Length;
            int sign = 1;

            while (i < n && str[i] == ' ')
                i++;

            while (i < n && (str[i] == '+' || str[i] == '-'))
            {
                sign = str[i] == '+' ? 1 : -1;
                i++;
            }

            long result = 0;
            while (i < n && char.IsDigit(str[i]))
            {
                result = result * 10 + (str[i] - '0');

                if (sign == 1 && result > int.MaxValue)
                    return int.MaxValue;
                if (sign == -1 && -(result) < int.MinValue)
                    return int.MinValue;
                i++;
            }

            return (int)(sign * result);


        }
    }
}
