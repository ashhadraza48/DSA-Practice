using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem26
    {
        public void PrintPascalTriangleWrapper()
        {
            int noOfRow = 5;
            PrintPascalTriangle(noOfRow);
        }

        //Optimal TC - O(N^2) SC - O(N)
        private static void PrintPascalTriangle(int row)
        {
            List<List<int>> pascalTriangle = new();
            for (int i = 1; i <= row; i++)
            {
                GenerateRow(i, pascalTriangle);
            }

            Console.WriteLine("Pascal Triangle:");
            foreach (var arr in pascalTriangle)
            {
                foreach (var ele in arr)
                {
                    Console.Write(ele + " ");
                }
                Console.WriteLine();
            }
        }

        private static void GenerateRow(int rowNo, List<List<int>> pascalTriangle)
        {
            int colLen = rowNo;
            List<int> rowList = new();
            int ans = 1;
            rowList.Add(ans);

            for (int j = 1; j < colLen; j++)
            {
                ans = ans * (rowNo - j);
                ans = ans / j;
                rowList.Add(ans);
            }

            pascalTriangle.Add(rowList);
        }


    }
}
