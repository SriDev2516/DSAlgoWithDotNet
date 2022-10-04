using System;
using System.Linq;

namespace FindMissingNumberInArray
{
    class Program
    {
        //Given an array of n-1 integers in the range from 1 to n
        //find the one number that is missing from the array.

        //Input: 1, 5, 2, 6, 4
        //Answer: 3
        static void Main(string[] args)
        {
            int result = FindTheMissingNumber(new int[] { 1, 5, 2, 6, 4 });
            Console.WriteLine(result);
        }

        private static int FindTheMissingNumber(int[] nums)
        {
            int n = nums.Length+1;
            int x1 = 0;
            for (int i = 1; i <= n; i++)
            {
                x1 ^= i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                x1 ^= nums[i];
            }

            return x1;
        }
    }
}
