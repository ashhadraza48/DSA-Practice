using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem29
    {
        public void FourSumWrapper()
        {
            int[] arr = { 1, -2, 3, 5, 7, 9 };
            int target = 7;
            FourSumOptimal(arr,target);
        }

        //Brute  TC - O(N^4) SC - O(Quadrapules Number)
        private static void FourSumBrute(int[] arr, int targetSum)
        {
            HashSet<List<int>> finalSet = new();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        for (int l = k + 1; l < arr.Length; l++)
                        {
                            if ((arr[i] + arr[j] + arr[k] + arr[l]) == targetSum)
                            {
                                List<int> set = new() { arr[i], arr[j], arr[k], arr[l] };
                                set.Sort();
                                finalSet.Add(set);
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Total Count of four sum:" + finalSet.Count);
        }


        //Better TC - O(N^3) SC - O(Quadruples Number) + O(N)
        private static void FourSumBetter(int[] arr, int targetSum)
        {
            HashSet<List<int>> finalSet = new();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    HashSet<int> set = new();
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        int fourth = targetSum - (arr[i] + arr[j] + arr[k]);
                        if (set.Contains(fourth))
                        {
                            List<int> tempList = new() { arr[i], arr[j], arr[k], fourth };
                            tempList.Sort();
                            finalSet.Add(tempList);
                        }
                        set.Add(arr[k]);
                    }
                }
            }

            Console.WriteLine("Total Count of four sum:" + finalSet.Count);
        }


        //Better with Different Approach  TC - O(N^3) SC - O(Quadruples Number)
        private static void FourSumOptimal(int[] arr, int targetSum)
        {
            HashSet<List<int>> finalSet = new();
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {

                if (i > 0 && arr[i] == arr[i - 1])
                    continue;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (j > i + 1 && arr[j] == arr[j - 1])
                        continue;

                    int k = j + 1;
                    int l = arr.Length - 1;

                    while (k < l)
                    {
                        int sum = arr[i] + arr[j] + arr[k] + arr[l];

                        if (sum < targetSum)
                        {
                            k++;
                        }
                        else if (sum > targetSum)
                        {
                            l--;
                        }
                        else
                        {
                            List<int> tempList = new() { arr[i], arr[j], arr[k], arr[l] };
                            tempList.Sort();
                            finalSet.Add(tempList);
                            k++;
                            l--;

                            while (k < l && arr[k] == arr[k + 1])
                            {
                                k++;
                            }

                            while (k < l && arr[l] == arr[l - 1])
                            {
                                l--;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Total Count of four sum:" + finalSet.Count);
        }


    }
}
