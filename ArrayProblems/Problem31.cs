using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem31
    {
        public void SubArrayCountWithTargetXORWrapper()
        {
            int[] arr = { 4, 2, 2, 6, 4 };
            int target = 6;
            NumberofsubArraysWithTargetXOR(arr, target);
        }

        //Optimal  TC - O(N)  SC - O(N)
        private static void NumberofsubArraysWithTargetXOR(int[] arr, int targetXOR)
        {
            Dictionary<int, int> xorCountDict = new(); //dictionary to store XOR and count
            int count = 0;
            int xor = 0;
            xorCountDict[xor] = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                xor = xor ^ arr[i];

                int req = xor ^ targetXOR;
                if (xorCountDict.ContainsKey(req))
                {
                    count += xorCountDict[req];
                }

                if (!xorCountDict.ContainsKey(xor))
                {
                    xorCountDict[xor] = 1;
                }
                else
                {
                    xorCountDict[xor] += 1;
                }
            }

            Console.WriteLine("Total Number of SubArray with given XOR:" + count);
        }
    }
}
