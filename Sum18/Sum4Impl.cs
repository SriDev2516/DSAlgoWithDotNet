using System;
using System.Collections.Generic;
using System.Text;

namespace Sum18
{
    public class Sum4Impl
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var list = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i + 1; j < nums.Length-1; j++)
                {
                  
                    int left = j + 1;
                    int right = nums.Length - 1;
                    Console.Write($"{nums[i]}, {nums[j]}, {nums[left]}, {nums[right]}");
                    Console.WriteLine();
                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (target == sum)
                        {
                            list.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }

            }

            return list;
        }
    }
}
