using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem13
    {
        public void SortArrayOf0s1s2sWrapper()
        {
            int[] arr = { 1, 0, 1, 1, 0, 2, 2, 0 };
            SortArrayOf0s1s2s(arr);

            Console.WriteLine("Sorted Array of 0,1,2:");
            foreach(var ele in arr)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }
        private static void SortArrayOf0s1s2s(int[] arr)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    Swap(arr, low, mid);
                    low++;
                    mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    Swap(arr, mid, high);
                    high--;
                }
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
