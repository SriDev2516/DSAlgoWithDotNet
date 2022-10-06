using System;
using System.Linq;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicatesAndReturnArray(new int[] { 2, 3, 3, 3, 6, 9, 9 });
        }

        private static void RemoveDuplicatesAndReturnArray(int[] nums)
        {
            int k = 0;
            int nonduplicate = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] != nonduplicate)
                {
                    k++;
                    nums[k] = nums[i];
                    nonduplicate = nums[i];
                    
                }
            }

          var result =  nums.Take(k+1).ToArray();
        }
    }
}
