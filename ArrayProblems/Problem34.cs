using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem34
    {
        public void FindMissingRepeatingNumbersWrapper()
        {
            int[] arr = { 3, 5, 4, 1, 1 };
            FindMissingRepeatingNumbersOptimal(arr);
        }

        //Brute  TC - O(N^2)  SC - O(1)
        private static void FindMissingRepeatingNumbersBrute(int[] arr)
        {
            int n = arr.Length;
            int repeatingNo = -1;
            int missingNo = -1;

            for (int i = 1; i < n; i++)
            {//loop for traversing all number between 1 to n
                int count = 0;
                for (int j = 0; j < n; j++)
                {//loop for traversing number in array
                    if (i == arr[j])
                    {
                        count += 1;
                    }
                }
                if (count != 0)
                {
                    repeatingNo = i;
                }
                else
                {
                    missingNo = i;
                }

                if (repeatingNo != -1 && missingNo != -1)
                    break;
            }

            Console.WriteLine("Repeating Number:" + repeatingNo + "   Missing Number:" + missingNo);
        }

        //Better TC - O(N)  SC - O(N)
        private static void FindMissingRepeatingNumbersBetter(int[] arr)
        {
            int n = arr.Length;
            int repeatingNo = -1;
            int missingNo = -1;
            int[] numSet = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                numSet[arr[i]] += 1;
            }
            repeatingNo = Array.IndexOf(numSet, 2, 1, n);
            missingNo = Array.IndexOf(numSet, 0, 1, n);

            Console.WriteLine("Repeating Number:" + repeatingNo + "   Missing Number:" + missingNo);
        }



        //Optimal TC - O(N) SC - O(1)
        private static void FindMissingRepeatingNumbersOptimal(int[] arr)
        {
            int n = arr.Length;
            long sumOfNaturalNum = (n * (n + 1)) / 2; //sum of n natural number
            long sumOfSqOfNaturalNum = (n * (n + 1) * (2 * n + 1)) / 6; //sum of square of n natural number
            long sumOfArrayNum = 0; //sum of numbers in array
            long sumOfSqOfArrayNum = 0; //sum of squares of number in array

            for (int i = 0; i < n; i++)
            {
                sumOfArrayNum += arr[i];
                sumOfSqOfArrayNum += (long)Math.Pow(arr[i], 2);
            }

            //repeatingNum - missingNum =  sumOfArrayNum - sumOfNaturalNum
            //repeatingNum^2 - missingNum^2 = sumOfSqOfArrayNum - sumOfSqOfNaturalNum
            //with these 2 equations below formula is written to fnd repeating and missing number

            int repeatingNum = (int)((sumOfArrayNum - sumOfNaturalNum) + ((sumOfSqOfArrayNum - sumOfSqOfNaturalNum) / (sumOfArrayNum - sumOfNaturalNum))) / 2;
            int missingNum = (int)(repeatingNum - (sumOfArrayNum - sumOfNaturalNum));
            Console.WriteLine("Repeating Number:" + repeatingNum + "   Missing Number:" + missingNum);
        }

    }
}
