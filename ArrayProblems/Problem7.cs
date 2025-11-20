using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem7
    {
        public void CombineTwoSortedArrayWrapper()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 7 };
            CombineTwoSortedArray(arr1, arr2);
        }

        private static void CombineTwoSortedArray(int[] arr1, int[] arr2)
        {
            int left = 0;
            int right = 0;

            int size1 = arr1.Length - 1;
            int size2 = arr2.Length - 1;
            List<int> temp = new List<int>();

            while (left <= size1 && right <= size2)
            {
                if (arr1[left] == arr2[right])
                {
                    temp.Add(arr1[left]);
                    left++;
                    right++;
                }
                else if (arr1[left] < arr2[right])
                {

                    temp.Add(arr1[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr2[right]);
                    right++;
                }
            }

            while (left <= size1)
            {
                temp.Add(arr1[left]);
                left++;
            }

            while (right <= size2)
            {
                temp.Add(arr2[right]);
                right++;
            }

            Console.WriteLine("Array after combining two Sorted Array:");
            foreach (var ele in temp)
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
        }


    }
}
