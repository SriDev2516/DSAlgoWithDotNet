using System;

namespace TwoSingleNumbers
{
    public class TwoSingleNumbersImpl
    {
        public static int[] TwoSingleNumberFinder(int[] nums)
        {
            int first = 0;
            int second = 0;
            int num = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                num ^= nums[i];
            }

            int rightMostBit = num & ~(num - 1);
            for (int i = 0; i < nums.Length; i++)
            {
                if((nums[i] & rightMostBit) == 0)
                {
                    first ^= nums[i];
                }
                else
                {
                    second ^= nums[i];
                }
            }

            return new int[] { first, second };
        }
    }
}