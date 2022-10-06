using System;
using System.Linq;

namespace RemoveAllInstancesOfAKey
{
    class Program
    {

        // Given an unsorted array of numbers and a target ‘key’, remove all instances of
        // ‘key’ in-place and return the new length of the array.

        //Input: [3, 2, 3, 6, 3, 10, 9, 3], Key=3
        //Output: 4
        //Explanation: The first four elements after removing every 'Key' will be[2, 6, 10, 9].
        static void Main(string[] args)
        {
            RemoveAllInstancesAndReturnNewArray(new int[] { 1, 2, 3, 4, 4, 4, 5, 1, 4, 5, 7, 8 }, 4);
        }

        private static void RemoveAllInstancesAndReturnNewArray(int[] nums, int key)
        {
            int k = 1;
          
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != key)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            var result = nums.Take(k);

        }
    }
}
