using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem11
    {
        public void GenerateSubArraysWrapper()
        {
            int[] arr = { 1, 2 };
            GenerateSubArrays(arr);
        }
        private static void GenerateSubArrays(int[] arr)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                List<int> subArray = new List<int>();

                for (int j = i; j < arr.Length; j++)
                {
                    subArray.Add(arr[j]);
                    result.Add(subArray);
                }

            }
            Console.WriteLine("Total SubArray Count:" + result.Count);
        }


        //using Linq

        private static void GenerateSubArraysUsingLinq(int[] arr)
        {
            var result = Enumerable.Range(0, arr.Length)
                             .SelectMany(start =>
                                 Enumerable.Range(start, arr.Length - start)
                                           .Select(len => arr.Skip(start)
                                                             .Take(len)
                                                             .ToList())
                             )
                             .ToList();

            Console.WriteLine("Total SubArray Count:" + result.Count);
        }

       //Subsets using Recursion
        public static void GenerateSubsets(int[] arr)
        {
            List<int> current = new List<int>();
            Generate(arr, 0, current);
        }

        private static void Generate(int[] arr, int index, List<int> current)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("[" + string.Join(",", current) + "]");
                return;
            }

            // Include arr[index]
            current.Add(arr[index]);
            Generate(arr, index + 1, current);

            // Exclude arr[index]
            current.RemoveAt(current.Count - 1);
            Generate(arr, index + 1, current);
        }

}
}
