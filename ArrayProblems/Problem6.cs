using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem6
    {
        public void FindIndexOfNumberWrapper()
        {
            int[] arr = { 1, 3, 4, 5, 3, 6 };
            int num = 3;
            FindIndexOfNumber(arr, num);
        }
        private static void FindIndexOfNumber(int[] arr, int num)
        {
            int idx = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    idx = i;
                    break;
                }
            }
            Console.WriteLine("The First Index is:"+idx);
        }

        //Using Linq
        private static void FindIndexOfNumberUsingLinq(int[] arr, int num)
        {
            List<int> l = arr.ToList();
            var idx = l.IndexOf(num);
            Console.WriteLine("The First Index is:" + idx);
        }
    }
}
