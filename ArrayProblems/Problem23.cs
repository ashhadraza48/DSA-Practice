using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem23
    {
        public void RotateMatrixBy90Wrapper()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            RotateMatrixBy90Optimal(arr);
        }

        //Brute Force TC - O(N^2)  SC - O(N^2)
        private static void RotateMatrixBy90(int[,] arr)
        {
            int len = arr.GetLength(0);
            int[,] finalMatrix = new int[len, len];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    finalMatrix[j, (len - i - 1)] = arr[i, j];
                }
            }

            Console.WriteLine("Rotated matrix By 90:");
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(finalMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Optimal  TC - O(N^2) SC - O(1)
        private static void RotateMatrixBy90Optimal(int[,] arr)
        {
            int len = arr.GetLength(0);

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    Swap(arr, i, j);
                }
            }

            for (int i = 0; i < len; i++)
            {
                int left = 0;
                int right = len - 1;
                while (left < right)
                {
                    SwapRowEle(arr, i, left, right);
                    left++;
                    right--;
                }
            }

            Console.WriteLine("Rotated matrix By 90:");
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Swap(int[,] arr, int i, int j)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }

        private static void SwapRowEle(int[,] arr, int i, int left, int right)
        {
            int temp = arr[i, left];
            arr[i, left] = arr[i, right];
            arr[i, right] = temp;
        }
    }
}
