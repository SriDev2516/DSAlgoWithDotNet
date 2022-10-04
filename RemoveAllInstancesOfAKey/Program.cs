using System;
using System.Linq;

namespace RemoveAllInstancesOfAKey
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveAllInstancesAndReturnNewArray(new int[] { 1, 2, 3, 4, 4, 4, 5, 1, 4, 5, 7, 8 }, 4);
        }

        private static void RemoveAllInstancesAndReturnNewArray(int[] nums, int key)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != key)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            var result = nums.Take(8).ToArray();
        }
    }
}
