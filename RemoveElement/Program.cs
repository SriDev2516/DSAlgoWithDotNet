using System;
using System.Collections.Generic;

namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3,2, 2, 3 };
            RemoveElement(arr, 3);
        }

        private static int RemoveElement(int[] nums, int val)
        {
            var k = nums.Length;
            List<int> rev = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    k--;
                }
                else
                {
                    rev.Add(nums[i]);
                }
            }

            nums = rev.ToArray();

            return k;
        }
    }
}
