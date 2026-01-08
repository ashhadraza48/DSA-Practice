using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem35
    {
        public void PrintNumberOfInversionsWrapper()
        {
            int[] arr = { 2, 3, 7, 1, 3, 5 };
            int count = PrintNumberOfInversionsUsingMergeSort(arr,0,arr.Length-1);

            Console.WriteLine("Total Inversion Count:" + count);
        }

        //Brute TC - O(N^2)  SC - O(N)
        private static void PrintNumberOfInversionsBrute(int[] arr)
        {
            int n = arr.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                        count += 1;
                }
            }

            Console.WriteLine("Total Inversion Count:" + count);
        }

        //Optimal TC - O(NlogN)   SC - O(1)
        private static int PrintNumberOfInversionsUsingMergeSort(int[] arr, int start, int end)
        {
            int count = 0;
            if (start >= end)
                return count;

            int mid = (start + end) / 2;
            count += PrintNumberOfInversionsUsingMergeSort(arr, start, mid);
            count += PrintNumberOfInversionsUsingMergeSort(arr, mid + 1, end);
            count += Merge(arr, start, mid, end);

            return count;
        }

        private static int Merge(int[] arr, int start, int mid, int end)
        {
            int left = start;
            int right = mid + 1;
            int[] temp = new int[end + 1];
            int idx = 0;
            int count = 0;

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
                    count += (mid - left + 1);
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
            return count;
        }


    }
}
