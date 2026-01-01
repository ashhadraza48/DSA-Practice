using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem27
    {
        public void FindMajorityElementWrapper()
        {
            int[] arr = { 1, 2, 1, 1, 3, 2 };
            FindMajorityElementOptimal(arr);
            Console.WriteLine();
        }
        //BruteForce  TC - O(N)  SC - O(N)
        private static void FindMajorityElement(int[] arr)
        {
            List<int> eleList = new();
            int thres = (arr.Length / 3) + 1;
            Dictionary<int, int> eleFre = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (eleFre.ContainsKey(arr[i]))
                {
                    eleFre[arr[i]] += 1;
                    if (eleFre[arr[i]] >= thres && !eleList.Contains(arr[i]))
                        eleList.Add(arr[i]);
                }
                else
                {
                    eleFre[arr[i]] = 1;
                }
            }

            foreach (var ele in eleList)
            {
                Console.Write(ele + " ");
            }


        }

        //Moore's Voting Algorithm TC - O(N) + O(N) SC - O(1)
        private static void FindMajorityElementOptimal(int[] arr)
        {
            int ele1 = 0;
            int ele2 = 0;
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (count1 == 0 && ele2 != arr[i])
                {
                    count1 += 1;
                    ele1 = arr[i];
                }
                else if (count2 == 0 && ele1 != arr[i])
                {
                    count2 += 1;
                    ele2 = arr[i];
                }
                else if (ele1 == arr[i])
                {
                    count1 += 1;
                }
                else if (ele2 == arr[i])
                {
                    count2 += 1;
                }
                else
                {
                    count1 -= 1;
                    count2 -= 1;
                }
            }

            count1 = 0;
            count2 = 0;
            List<int> eleList = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ele1)
                    count1 += 1;
                if (arr[i] == ele2)
                    count2 += 1;
            }

            if (count1 >= ((arr.Length / 3) + 1))
                eleList.Add(ele1);

            if (count2 >= ((arr.Length / 3) + 1))
                eleList.Add(ele2);

            if (eleList.Count != 0)
            {
                Console.Write("Majority Element in Array:");
                foreach (var ele in eleList)
                {
                    Console.Write(ele + " ");
                }
            }
            else
                Console.WriteLine("Array has no Majority Element.");
        }

    }
}
