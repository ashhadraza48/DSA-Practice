using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem20
    {
        public void LeadersofArrayWrapper()
        {
            int[] arr = { 1, 2, 5, 3, 1, 2 };
            PrintLeadersOfArrayOptimal(arr);

        }
        //BruteForce TC - O(N^2) SC - O(N)
        private static void PrintLeadersOfArray(int[] arr)
        {
            List<int> leaderArray = new();

            for (int i = 0; i < arr.Length; i++)
            {
                bool leader = true;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        leader = false;
                        break;
                    }
                }

                if (leader)
                    leaderArray.Add(arr[i]);
            }

            Console.WriteLine("Leaders are:");
            foreach (var ele in leaderArray)
            {
                Console.Write(ele + " ");
            }
        }


        //Optimal Solution TC - O(N) SC - O(N)
        private static void PrintLeadersOfArrayOptimal(int[] arr)
        {
            List<int> leaderArray = new();
            int max = int.MinValue;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    leaderArray.Insert(0, max);
                }
            }

            Console.WriteLine("Leaders are:");
            foreach (var ele in leaderArray)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }
    }
}
