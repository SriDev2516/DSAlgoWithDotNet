using System;

namespace PairWithTargetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mainly used if the array is sorted.
            var result = FindThePairWithTargetSum(new int[] { 1, 2, 3, 4, 5, 6 }, 6);
        }

        private static int[] FindThePairWithTargetSum(int[] nums, int target_sum)
        {
            int start = 0;
            int end = nums.Length - 1;

            while(start < end)
            {
                var target = nums[start] + nums[end];
                if (target == target_sum) return new int[] { start, end };
                if(target < target_sum)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
