using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem18
    {
        public void GenerateAllPermutationWrapper() 
        {
            int[] arr = { 2, 4, 5 };
            List<List<int>> finalList = new();
            GenerateAllPermutationsSortedOptimal(arr,finalList);
        }
        ///Brute Force approach Time Complexity :O(n!*n) Sapce Complexity : O(n) + O(n)
        private static void GenerateAllPermutations(int[] arr, List<List<int>> finalList)
        {
            List<int> tempList = new();
            bool[] usedEle = new bool[arr.Length];
            //Array.Sort(arr); //for permutations in sorted order
            Permute(arr, tempList, finalList, usedEle);
            Console.WriteLine("total permutation count:" + finalList.Count);
        }

        private static void Permute(int[] arr, List<int> tempList, List<List<int>> finalList, bool[] usedEle)
        {
            if (tempList.Count == arr.Length)
            {
                finalList.Add(new List<int>(tempList));
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!usedEle[i])
                {
                    usedEle[i] = true;
                    tempList.Add(arr[i]);
                    Permute(arr, tempList, finalList, usedEle);
                    tempList.RemoveAt(tempList.Count - 1);
                    usedEle[i] = false;
                }
            }
        }



        //Optimal Solution
        public static void GenerateAllPermutationsSortedOptimal(int[] arr, List<List<int>> finalList)
        {
            Array.Sort(arr); //for permutations in sorted order
            PermuteOptimal(0, arr, finalList);
            Console.WriteLine("total permutation Count:" + finalList.Count);
        }

        private static void PermuteOptimal(int idx, int[] arr, List<List<int>> finalList)
        {
            if (idx == arr.Length)
            {
                finalList.Add(arr.ToList());
                return;
            }

            for (int i = idx; i < arr.Length; i++)
            {
                Swap(idx, i, arr);
                PermuteOptimal(idx + 1, arr, finalList);
                Swap(idx, i, arr);
            }
        }

        private static void Swap(int i, int j, int[] arr)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
