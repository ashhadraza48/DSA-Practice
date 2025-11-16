using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem4
    {
        public void LeftRotateArrayByKSteps()
        {
            int[] arr = { 1, 4, 2, 5, 6, 7 };
            LeftRotateArray(arr, 3);
        }
        public static void LeftRotateArray(int[] arr, int k)
        {
            k = k % arr.Length;
            for (int j = 0; j < k; j++)
            {
                int temp = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = temp;
            }

            Console.Write($"Array after rotating left {k} steps:");
            foreach (var ele in arr)
            {
                Console.Write(ele+ " ");
            }
            Console.WriteLine();
        }
    }
}
