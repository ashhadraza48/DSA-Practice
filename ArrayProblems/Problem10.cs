using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem10
    {
        public void FindNumberWithSingleOccurrenceWrapper()
        {
            int[] arr = { 1, 1, 2, 5, 4, 5, 4 };
            FindNumberWithSingleOccurrence(arr);
        }
        private static void FindNumberWithSingleOccurrence(int[] arr)
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

            var res = d.FirstOrDefault(x => x.Value == 1);
            if (res.Value == 1)
                Console.WriteLine("Single Occurred integer:"+res.Key);
            else
                Console.WriteLine("No element is Single occurence");
        }
    }
}
