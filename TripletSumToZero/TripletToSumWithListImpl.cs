using System;
using System.Collections.Generic;
using System.Text;

namespace TripletSumToZero
{
    public class TripletToSumWithListImpl
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || i > 0 && nums[i] != nums[i - 1])
                {
                    int left = i + 1;
                    int right = nums.Length - 1;
                    int target = -nums[i];
                    while (left < right)
                    { //left = -1, right = 0
                        int sum = nums[left] + nums[right];
                        if (target == sum)
                        {
                            list.Add(new List<int>() { nums[i], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;
                            left++;
                            right--;
                        }
                        else if (sum > target)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }
                }
            }

            return list;

        }
    }
}
