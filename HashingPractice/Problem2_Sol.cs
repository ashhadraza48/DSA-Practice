using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingPractice
{
    public class Problem2_Sol
    {
        public void PrintArrayMostFreqElement(int[] arr)
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

            var maxValue = dict.Values.Max();
            var maxelList = dict.Where(x => x.Value == maxValue).Select(x => x.Key).ToList();


            Console.WriteLine(maxelList.Min());
        }
    }
}
