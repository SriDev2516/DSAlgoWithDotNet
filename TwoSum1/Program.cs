using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = TwoSum(new int[] { 3,3 }, 6);
            Console.WriteLine(result[0] + "  " + result[1]);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int complement = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                if (result.ContainsKey(complement)){
                   
                    return new int[] { i, result[complement] };
                }

                result[nums[i]] = i;
            }

            return new int[2];
        }
    }
}
