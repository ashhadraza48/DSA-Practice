using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem14
    {
        public void MajorityElementWrapper()
        {
            int[] arr = { 7, 0, 0, 1, 7, 7, 2, 7, 7 };
            FindMajorityElement(arr);
        }
        private static void FindMajorityElement(int[] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (d.ContainsKey(arr[i]))
                {
                    d[arr[i]]++;
                }
                else
                {
                    d[arr[i]] = 1;
                }
            }

            int len = arr.Length / 2;
            var res = d.Where(x => x.Value > len).ToDictionary(y => y.Key, y => y.Value);

            Console.WriteLine("Majority Element in an array:");
            foreach (var ele in res)
            {
                Console.Write(ele.Key + " ");
            }
            Console.WriteLine();
        }


        //Moore's Voting Algorithm TC - O(N) SC - O(1)
        private static void FindMajorityElementOptimal(int[] arr)
        {
            int ele = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (count == 0)
                {
                    count += 1;
                    ele = arr[i];
                }
                else if (ele == arr[i])
                {
                    count += 1;
                }
                else
                {
                    count -= 1;
                }
            }

            count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ele)
                    count += 1;
            }

            if (count >= ((arr.Length / 2) + 1))
                Console.WriteLine("Majority Element:" + ele);
            else
                Console.WriteLine("Array has no Majority Element");
        }
    }
}
