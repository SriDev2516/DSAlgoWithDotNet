using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSingleNumbers
{
    public class TwoSingleNumbersImpl
    {
        public static int[] TwoSingleNumberFinder(int[] nums)
        {
            int x = nums[0];
            int first = 0;
            int second = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                x = x ^ nums[i];
            }

            int rightMostBit = x & ~(x-1);

            for (int i = 0; i < nums.Length; i++)
            {
                if((rightMostBit & nums[i]) == 0)
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
