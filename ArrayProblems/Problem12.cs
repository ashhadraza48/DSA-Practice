using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem12
    {
        public void TwoSumWrapper()
        {
            int[] arr = { 1, 6, 2, 10, 3 };
            int tar = 7;
            FindIndicesOfTwoSum(arr, tar);
        }
        private static void FindIndicesOfTwoSum(int[] arr, int tar)
        {
            bool sumFound = false;

            Console.WriteLine("Two Sum Index:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) == tar)
                    {
                        Console.WriteLine("[" + i + "," + j + "]");
                        sumFound = true;
                        break;
                    }
                }
                if (sumFound)
                    break;
            }
        }

        //Using Dictionary reduces Time Complexity to O(n) 
        private void FindIndicesOfTwoSumOptimized(int[] arr, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];

                if (map.ContainsKey(complement))
                {
                    Console.WriteLine("[" + map[complement] + "," + i + "]");
                    return;
                }

                if (!map.ContainsKey(arr[i]))  // avoid overwriting duplicate values
                    map.Add(arr[i], i);
            }

            Console.WriteLine("No pair found");
        }



        #region NSumLogic
        public List<List<int>> NSum(int[] nums, int target, int N)
        {
            Array.Sort(nums);
            return NSumHelper(nums, target, N, 0);
        }

        private List<List<int>> NSumHelper(int[] nums, int target, int N, int start)
        {
            List<List<int>> result = new List<List<int>>();
            int n = nums.Length;

            // Base case: Not enough numbers
            if (N < 2 || n - start < N)
                return result;

            // 2-Sum base case using two pointers
            if (N == 2)
            {
                int left = start, right = n - 1;

                while (left < right)
                {
                    int sum = nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[left], nums[right] });

                        left++;
                        right--;

                        // Skip duplicates
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
                return result;
            }

            // N > 2: recursively reduce to (N-1)-Sum
            for (int i = start; i < n - (N - 1); i++)
            {
                // Skip duplicates
                if (i > start && nums[i] == nums[i - 1])
                    continue;

                int value = nums[i];

                // Recurse for (N-1)-Sum
                var subResults = NSumHelper(nums, target - value, N - 1, i + 1);

                // Attach nums[i] to each of the combinations
                foreach (var sub in subResults)
                {
                    List<int> newList = new List<int> { value };
                    foreach (var s in sub)
                        newList.Add(s);

                    result.Add(newList);
                }
            }

            return result;
        }

        #endregion NSumLogic


    }
}
