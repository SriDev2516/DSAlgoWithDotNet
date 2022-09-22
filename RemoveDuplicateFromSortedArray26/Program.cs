using System;
using System.Collections.Generic;

namespace RemoveDuplicateFromSortedArray26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicates(new int[] { 1, 1, 2, 3 });
        }


        public static int RemoveDuplicates(int[] nums)
        {
            List<int> list = new List<int>();
            int k = 0;
            for (int j = 0; j < nums.Length; j++)
            {

                if (!list.Contains(nums[j]))
                {
                    list.Add(nums[j]);
                    k++;
                }


            }
            //nums = list.ToArray();
            Array.Copy(list.ToArray(), nums, k);
            return k;

        }
    }
}
