using System;

namespace FindPivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var nums = new int[] { 1, 7, 3, 6, 5, 6 };
            var index = solution.PivotIndex(nums);

            Console.WriteLine(index);
        }
    }

    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int leftSum = 0;
            var sum = Total(nums, 0, nums.Length);

            for (int j = 0; j < nums.Length; j++)
            {
                if (leftSum == sum - leftSum - nums[j]) return j;           
                leftSum = leftSum + nums[j];
            }

            return -1;

        }

        public int Total(int[] arr, int left, int right)
        {
            int totalSum = 0;
            for (int i = left; i < right; i++)
            {
                totalSum += arr[i];

            }

            return totalSum;
        }
    }
}
