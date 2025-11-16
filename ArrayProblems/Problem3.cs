using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem3
    {
        public void CheckSortedArray()
        {
            int[] arr = { 1, 2,3,4,5 };
            var res = IsSortedArray(arr);
            Console.WriteLine("Array is Sorted:" +res);
        }

        public static bool IsSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
            return true;
        }
    }
}
