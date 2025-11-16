using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem5
    {
        public void MoveZeoresToArrayEnd()
        {
            int[] arr = { 16, 3, 7, 8, 0, 5, 0, 4 };
            MoveZeroesToEnd(arr);
        }
        private static void MoveZeroesToEnd(int[] arr)
        {
            int idx = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[idx] = arr[i];
                    idx++;
                }

            }
            while (idx < arr.Length)
            {
                arr[idx] = 0;
                idx++;
            }

            Console.Write("Array after moving zeroes to End:");
            foreach (var ele in arr)
            {
                Console.Write(ele+" ");
            }
            Console.WriteLine();
        }
    }
}
