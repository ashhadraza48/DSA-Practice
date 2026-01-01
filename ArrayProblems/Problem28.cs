using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem28
    {
        public void ThreeSumWrapper()
        {
            int[] arr = { 2, -2, 0, 3, -3, 5 };
            ThreeSumOptimal(arr);
        }


        //BruteForce  TC - O(N^3)  SC - O(Triplets Number);
        private static void ThreeSumBrute(int[] arr)
        {
            HashSet<List<int>> finalSet = new();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            List<int> l = new List<int>() { arr[i], arr[j], arr[k] };
                            l.Sort();
                            finalSet.Add(l);
                        }
                    }
                }
            }

            Console.WriteLine("Total Count of three sum:" + finalSet.Count);
        }

        //Better TC - O(N^2) SC - O(Triplets Number) + O(N)
        private static void ThreeSumBetter(int[] arr)
        {
            HashSet<List<int>> finalSet = new();

            for (int i = 0; i < arr.Length; i++)
            {
                HashSet<int> set = new();
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int thirdNum = -(arr[i] + arr[j]);
                    if (set.Contains(thirdNum))
                    {
                        List<int> l = new List<int>() { arr[i], arr[j], thirdNum };
                        l.Sort();
                        finalSet.Add(l);
                    }
                    set.Add(arr[j]);
                }
            }

            Console.WriteLine("Total Count of three sum:" + finalSet.Count);

        }

        //Different Approach TC - O(N^2) SC - O(Triplets Number)
        private static void ThreeSumOptimal(int[] arr)
        {
            Array.Sort(arr);
            HashSet<List<int>> finalSet = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                    continue;

                int j = i + 1;
                int k = arr.Length - 1;

                while (j < k)
                {
                    int sum = arr[i] + arr[j] + arr[k];

                    if (sum < 0)
                    {
                        j++;
                    }
                    else if (sum > 0)
                    {
                        k--;
                    }
                    else
                    {
                        List<int> l = new List<int>() { arr[i], arr[j], arr[k] };
                        l.Sort();
                        finalSet.Add(l);
                        j++;
                        k--;

                        while (j < k && arr[j] == arr[j + 1])
                        {
                            j++;
                        }
                        while (j < k && arr[k] == arr[k - 1])
                        {
                            k--;
                        }
                    }
                }
            }

            Console.WriteLine("Total Count of three sum:" + finalSet.Count);
        }
    }
}
