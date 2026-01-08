using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem37
    {
        public void MaxProductofSubArrayWrapper()
        {
            int[] arr = { 4, 5, 3, 7, 1, 2 };
            MaxProductofSubArrayOptimal(arr);
        }

        //Brute TC - O(N^2)  SC - O(1)
        private static void MaxProductofSubArrayBrute(int[] arr)
        {
            int n = arr.Length;
            int maxProd = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currProd = 1;
                for (int j = i; j < n; j++)
                {
                    currProd = currProd * arr[j];
                }
                maxProd = Math.Max(maxProd, currProd);

            }
            Console.WriteLine("Maximum Product of SubArray:" + maxProd);

        }

        //Optimal  TC - O(N)  SC - O(1)
        private static void MaxProductofSubArrayOptimal(int[] arr)
        {
            int n = arr.Length;
            int prefProd = 1;
            int suffProd = 1;
            int maxProd = int.MinValue;

            for (int i = 0; i < n; i++)
            {

                if (prefProd == 0)
                    prefProd = 1;

                if (suffProd == 0)
                    suffProd = 1;

                prefProd = prefProd * arr[i];
                suffProd = suffProd * arr[n - i - 1];

                maxProd = Math.Max(maxProd, Math.Max(prefProd, suffProd));
            }

            Console.WriteLine("Maximum Product of SubArray:" + maxProd);
        }
    }
}
