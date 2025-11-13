using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingPractice
{
    public class Problem1_Sol
    {
        public void PrintArrayElementFreq(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]] = dict[arr[i]] + 1;
                }
                else
                    dict[arr[i]] = 1;
            }

            List<string> l = new List<string>();


            foreach (var ele in dict)
            {
                //l.Add(t);
                l.Add("[" + ele.Key + "," + ele.Value + "]");
            }

            var res = "[" + String.Join(",", l) + "]";

            Console.WriteLine(res);
        }
    }
}
