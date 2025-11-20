using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem8
    {
        public void MissingNumberWrapper()
        {
            int[] arr = { 0, 1, 3, 5, 4 };
            MissingNumber(arr);
        }
        private static void MissingNumber(int[] arr)
        {
            for (int i = 0; i <= arr.Length; i++)
            {
                if (!arr.Contains(i))
                {
                    Console.WriteLine("Missing Number from array:" + i);
                    break;
                }
            }
        }
    }
}
