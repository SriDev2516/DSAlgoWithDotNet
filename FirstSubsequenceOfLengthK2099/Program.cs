using System;

namespace FirstSubsequenceOfLengthK2099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = MaxSubsequence(new int[] { -1,-2,3,4}, 3);
        }

        public static int[] MaxSubsequence(int[] nums, int k)
        {

            Array.Sort(nums);

            var result = new int[k];

            for (int i = nums.Length; i > k; i--)
            {
                result[i] = nums[k];
            }

            return result;
        }
    }
}
