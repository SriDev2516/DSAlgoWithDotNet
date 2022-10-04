using System;

namespace TwoSingleNumbers
{
    class Program
    {
        //In a non-empty array of numbers, every number appears exactly twice except two
        //numbers that appear only once.
        //Find the two numbers that appear only once.

        //Input: [1, 4, 2, 1, 3, 5, 6, 2, 3, 5]
        //Output: [4, 6]

        //Input: [2, 1, 3, 2]
        //Output: [1, 3]
        static void Main(string[] args)
        {
            var result = FindTwoSingleNumbers(new int[] { 2, 1, 3, 2 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] FindTwoSingleNumbers(int[] nums)
        {
            var result = new int[2];
            int x1 = 0;
            int left = 0;
            int right = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                x1 ^= nums[i];
            }

            int rightmostbit = x1 & ~(x1 - 1);

            for (int i = 0; i < nums.Length; i++)
            {
                if ((rightmostbit & nums[i]) == 0)
                {
                    left ^= nums[i];
                }
                else
                {
                    right ^= nums[i];
                }
            }

            return new int[] { left, right };
        }
    }
}
