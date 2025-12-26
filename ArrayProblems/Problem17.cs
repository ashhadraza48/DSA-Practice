using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem17
    {
        public void RearrangeArrayBySignWrapper()
        {
            int[] arr = { 2, 4, 5, -1, -3, -4 };
            RearrangeArrayOptimalVersion(arr);
        }

        //bruteforce approach
        private static void RearrangeArray(int[] arr)
        {
            List<int> posList = new();
            List<int> negList = new();
            int[] finalList = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    posList.Add(arr[i]);
                }
                else
                {
                    negList.Add(arr[i]);
                }
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                finalList[2 * i] = posList[i];
                finalList[2 * i + 1] = negList[i];
            }

            Console.WriteLine("Rearranged Array with positive and Negative numbers:");
            foreach (var ele in finalList)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();

        }


        //optimal solution when array has equal number of +ve & -ve elements
        private static void RearrangeArrayOptimalVersion(int[] arr)
        {
            int[] finalList = new int[arr.Length];
            int posIdx = 0;
            int negIdx = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    finalList[posIdx] = arr[i];
                    posIdx += 2;
                }
                else
                {
                    finalList[negIdx] = arr[i];
                    negIdx += 2;
                }
            }

            Console.WriteLine("Rearranged Array with positive and Negative numbers:");
            foreach (var ele in finalList)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();

        }

    }
}
