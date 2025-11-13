using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem2
    {

        public void SecondLargestElementofArray()
        {
            int[] arr = { 1, 5, 8, 2, 3, 2 };
            PrintSecondLargestElement(arr);
        }

        //Using Linq
        public static void PrintSecondLargestElementUsingLinq(int[] arr)
        {
            List<int> numList = arr.Distinct().ToList();
            if (numList.Count() != 1)
            {
                var secondLarEle = numList.OrderByDescending(x => x).Skip(1).Take(1).FirstOrDefault();
                Console.WriteLine("second Largest Element " + secondLarEle);
            }
            else
            {
                Console.WriteLine("Array is having only one Element.");
            }
        }

        //using Loop
        public static void PrintSecondLargestElement(int[] arr)
        {
            int larEle = arr[0];
            int secondLarEle = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > larEle)
                {
                    secondLarEle = larEle;
                    larEle = arr[i];
                }
                else if (arr[i] > secondLarEle && arr[i] < larEle)
                {
                    secondLarEle = arr[i];
                }
            }


            if (larEle != secondLarEle)
                Console.WriteLine("second Largest Element " + secondLarEle);
            else
                Console.WriteLine("Array is having only one Element.");
        }


       
    }
}
