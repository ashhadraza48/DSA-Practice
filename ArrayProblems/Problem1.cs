using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem1
    {
        public void LargestElementofArray()
        {
            int[] arr = { 1, 5, 8, 2, 3, 2 };
            PrintLargestEleUsingLinq(arr);
        }
        //using Linq
        private static void PrintLargestEleUsingLinq(int[] arr)
        {

            var maxVal = arr.Max(x => x);

            Console.WriteLine("Largest Element " + maxVal);
        }

        //using Loop
        private static void PrintLargestEle(int[] arr)
        {
            int larEle = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > larEle)
                    larEle = arr[i];
            }

            Console.WriteLine("Largest Element " + larEle);
        }
    }

}

