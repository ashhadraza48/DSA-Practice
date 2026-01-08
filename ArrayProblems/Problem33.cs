using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem33
    {
        public void MergeTwoSortedArraysWrapper()
        {
            int[] temp = { -5, -2, 4, 5 };
            int[] arr1 = new int[7];
            Array.Copy(temp, arr1, temp.Length);
            int[] arr2 = { -3, 1, 8 };
            MergeTwoSortedArraysOptimal(arr1, arr2);
        }

        //BruteForce  TC - O(N+M) + O(N+M)   SC - O(N+M)
        private static void MergeTwoSortedArraysBrute(int[] arr1, int[] arr2)
        {
            int arr2Len = arr2.Length;
            int arr1Len = arr1.Length - arr2.Length; //array1 has total length of array1+array2 to get combined result
            int[] result = new int[arr1Len + arr2Len];
            int left = 0;
            int right = 0;
            int idx = 0;

            while (left < arr1Len && right < arr2Len)
            {
                if (arr1[left] <= arr2[right])
                {
                    result[idx] = arr1[left];
                    left++;
                    idx++;
                }
                else
                {
                    result[idx] = arr2[right];
                    right++;
                    idx++;
                }
            }

            while (left < arr1Len)
            {
                result[idx] = arr1[left];
                left++;
                idx++;
            }

            while (right < arr2Len)
            {
                result[idx] = arr2[right];
                right++;
                idx++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                arr1[i] = result[i];
            }

            Console.WriteLine("Merged Array:");
            foreach (var ele in arr1)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }


        //Optimal  TC - O(min(M,N)) + O(MlogM) + O(NlogN)  SC - O(1)
        private static void MergeTwoSortedArraysOptimal(int[] arr1, int[] arr2)
        {
            int arr2Len = arr2.Length;
            int arr1Len = arr1.Length - arr2.Length;
            int left = arr1Len - 1;
            int right = 0;

            while (left >= 0 && right < arr2Len)
            {
                if (arr2[right] < arr1[left])
                {
                    Swap(arr1, arr2, left, right);
                    right++;
                    left--;
                }
                else
                {
                    break;
                }
            }

            Array.Sort(arr1, 0, arr1Len);
            Array.Sort(arr2);

            for (int i = 0; i < arr2Len; i++)
            {
                arr1[arr1Len + i] = arr2[i];
            }

            Console.WriteLine("Merged Array:");
            foreach (var ele in arr1)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }

        private static void Swap(int[] arr1, int[] arr2, int arr1Idx, int arr2Idx)
        {
            int temp = arr1[arr1Idx];
            arr1[arr1Idx] = arr2[arr2Idx];
            arr2[arr2Idx] = temp;
        }

    }
}
