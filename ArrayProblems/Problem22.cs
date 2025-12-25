using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem22
    {
        public void SetMatrizZeroesWrapper()
        {
            int[,] arr = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1 , 1 } }; 
            SetMatrixZeroesOptimal(arr);    
        }

        //BruteForce TC - O(N^2) SC - O(N)+(N)
        private static void SetMatrixZeroes(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);
            int[] row = new int[rowLength];
            int[] col = new int[colLength];

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        row[i] = -1;
                        col[j] = -1;
                    }
                }
            }

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (row[i] == -1 || col[j] == -1)
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("Matrix with Zero:");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        //Optimal TC - O(N^2)  SC - O(1)
        private static void SetMatrixZeroesOptimal(int[,] arr)
        {
            int col0 = 1;
            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        arr[i, 0] = 0;

                        if (j != 0)
                            arr[0, j] = 0;
                        else
                            col0 = 0;
                    }
                }
            }

            for (int i = 1; i < rowLen; i++)
            {
                for (int j = 1; j < colLen; j++)
                {
                    if (arr[i, j] != 0 && (arr[0, j] == 0 || arr[i, 0] == 0))
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            if (arr[0, 0] == 0)
            {
                for (int j = 0; j < colLen; j++)
                {
                    arr[0, j] = 0;
                }
            }

            if (col0 == 0)
            {
                for (int i = 0; i < rowLen; i++)
                {
                    arr[i, 0] = 0;
                }
            }

            Console.WriteLine("Matrix with Zero:");
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
