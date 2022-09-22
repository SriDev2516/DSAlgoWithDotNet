using System;

namespace MoveZerosToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
        }

        public static void MoveZeroes(int[] nums)
        {

            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[counter] = nums[i];
                    counter++;
                }

            }

            if (counter != nums.Length)
            {
                while (counter < nums.Length)
                {
                    nums[counter] = 0;
                    counter++;
                }
            }
        }
    }
}
