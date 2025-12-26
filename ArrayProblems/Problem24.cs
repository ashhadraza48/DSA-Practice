using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem24
    {
        public void MatrixSpiralOrderWrapper()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            PrintMatrixSpiralOrder(arr);
        }

        //Optimal TC - O(N*M) SC - O(N*M)
        private static void PrintMatrixSpiralOrder(int[,] arr)
        {
            List<int> finalList = new();
            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);
            int top = 0;
            int bottom = colLen - 1;
            int left = 0;
            int right = rowLen - 1;

            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++)
                {
                    finalList.Add(arr[top, i]);
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    finalList.Add(arr[i, right]);
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        finalList.Add(arr[bottom, i]);
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        finalList.Add(arr[i, left]);
                    }
                    left++;
                }
            }

            Console.WriteLine("Matrix in Spiral:");
            foreach (var ele in finalList)
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
        }

    }
}
