using System;
using System.Collections.Generic;
using System.Text;

namespace TripletsWithSmallestSum
{
    class SmallestSumTriplets
    {
        public int FindTheSum(int[] nums, int target)
        {
            IList<IList<int[]>> list = new List<IList<int[]>>();
            int count = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-2; i++)
            {
                int left = i+1;
                int right = nums.Length - 1;
                int targetSum = target - nums[i];

                while (left < right)
                {
                    int sum = nums[right] + nums[left];
                    
                        if(sum < targetSum)
                        {
                        count += right - left;
                        list.Add(new List<int[]>() { new int[] { nums[i], nums[left], nums[right] } });
                        left++;
                        }
                        else
                        {
                            right--;
                        }
                        
                       
                      
                }
            }

            return count;
        }
    }
}
