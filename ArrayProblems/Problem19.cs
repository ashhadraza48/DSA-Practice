using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem19
    {
        public void FindNextPermutationWrapper()
        {
            int[] arr = { 1, 2, 3 };
            FindNextPermutaion(arr);
        }
        public static void FindNextPermutaion(int[] arr)
        {
            Problem18 problem18 = new Problem18();
            List<List<int>> finalList = new();
            int[] temp = (int[])arr.Clone();
            Problem18.GenerateAllPermutationsSortedOptimal(arr, finalList);
            var currArrIdx = finalList.FindIndex(innerList => innerList.SequenceEqual(temp));
            Console.WriteLine("Next Permutation is :");
            foreach (var ele in finalList[currArrIdx + 1])
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
            
        }

    }
}
