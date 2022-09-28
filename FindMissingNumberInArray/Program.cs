using System;

namespace FindMissingNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMissingNumberWithXOR(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        }

        public static int FindMissingNumberWithXOR(int[] nums)
        {
            int x1 = 0;
            int n = nums.Length + 1;

            for (int i = 0; i < n; i++)
            {
                x1 = x1 ^ i;
            }

            int x2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                x2 = x2 ^ nums[i];
            }

            return x1 ^ x2;
        }

        
    }
}
