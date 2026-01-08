using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem36
    {
        public void ReversePairCountWrapper()
        {
            int[] arr = { 6, 4, 1, 2, 7 };
            int count = ReversePairCountUsingMergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Total Reverse Pair Count:" + count);
        }

        //Brute  TC - O(N^2)  SC - O(1)
        private static void ReversePairCountBrute(int[] arr)
        {
            int n = arr.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > (2 * arr[j]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Total Reverse Pair Count:" + count);
        }

        //Optimal  TC - O(2nLogn)  SC - O(n)
        private static int ReversePairCountUsingMergeSort(int[] arr, int start, int end)
        {
            int count = 0;
            if (start >= end)
                return count;

            int mid = (start + end) / 2;
            count += ReversePairCountUsingMergeSort(arr, start, mid);
            count += ReversePairCountUsingMergeSort(arr, mid + 1, end);
            count += CountPairs(arr, start, mid, end);
            Merge(arr, start, mid, end);

            return count;
        }


        private static void Merge(int[] arr, int start, int mid, int end)
        {
            int left = start;
            int right = mid + 1;
            int[] temp = new int[end + 1];
            int idx = 0;

            while (left <= mid && right <= end)
            {
                if (arr[left] <= arr[right])
                {
                    temp[idx] = arr[left];
                    left++;
                    idx++;
                }
                else
                {
                    temp[idx] = arr[right];
                    right++;
                    idx++;
                }
            }

            while (left <= mid)
            {
                temp[idx] = arr[left];
                left++;
                idx++;
            }

            while (right <= end)
            {
                temp[idx] = arr[right];
                right++;
                idx++;
            }

            for (int i = start; i <= end; i++)
            {
                arr[i] = temp[i - start];
            }
        }

        //[7,15,20] [2,6,8]
        private static int CountPairs(int[] arr, int start, int mid, int end)
        {
            int left = start;
            int right = mid + 1;
            int count = 0;

            for (int i = left; i <= mid; i++)
            {
                while (right <= end && arr[i] > (2 * arr[right]))
                    right++;

                count += right - (mid + 1);
            }

            return count;

        }
    }
}
