using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Problem6
    {
        public void AreRotationsWrapper()
        {
            string s = "abcde";
            string goal = "cdeab";
            var res = AreRotations(s, goal);
            Console.WriteLine($"{s} and {goal} are rotations of one other: {res}");
        }

        //TC - O(1)  SC - O(1)
        private static bool AreRotations(string s, string goal)
        {
            // Must be same length and not null
            if (s == null || goal == null || s.Length != goal.Length)
                return false;

            // Special case for empty strings if necessary
            if (s.Length == 0) return true;

            // Double the string and check if 'goal' is a substring
            return (s + s).Contains(goal);
        }

        private static string RotateLeft(string input, int n)
        {
            if (string.IsNullOrEmpty(input)) return input;
            n %= input.Length; // Handle shifts larger than string length
            return input[n..] + input[..n]; //Range(..) Operator is used.it includes first element and excludes last element
        }

        private static string RotateRight(string input, int n)
        {
            if (string.IsNullOrEmpty(input)) return input;
            n %= input.Length;
            return input[^n..] + input[..^n]; //Index(^) oprator is used.it is the index from the last
        }

        #region Reversal Algorithm
        public static string RotateLeftWithoutOperator(string s, int k)
        {
            if (string.IsNullOrEmpty(s)) return s;
            int n = s.Length;
            k %= n; // Handle cases where k > n

            char[] chars = s.ToCharArray();

            // 1. Reverse first k elements
            Reverse(chars, 0, k - 1);
            // 2. Reverse remaining n-k elements
            Reverse(chars, k, n - 1);
            // 3. Reverse the whole array
            Reverse(chars, 0, n - 1);

            return new string(chars);
        }

        public static string RotateRightWithoutOperator(string s, int k)
        {
            if (string.IsNullOrEmpty(s)) return s;
            int n = s.Length;
            k %= n; // Handle cases where k > n

            char[] chars = s.ToCharArray();

            // 1. Reverse last k elements
            Reverse(chars, n - k, n - 1);
            // 2. Reverse remaining n-k elements
            Reverse(chars, 0, n - k);
            // 3. Reverse the whole array
            Reverse(chars, 0, n - 1);

            return new string(chars);
        }

        private static void Reverse(char[] arr, int start, int end)
        {
            while (start < end)
            {
                (arr[start], arr[end]) = (arr[end], arr[start]); // Tuple swap
                start++;
                end--;
            }
        }

        #endregion Reversal Algorithm
    }
}
