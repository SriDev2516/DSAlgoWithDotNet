using System;

namespace Sum18
{
    // Given an array nums of n integers, return an array of all the unique quadruplets[nums[a], nums[b], nums[c], nums[d]] such that:

    //Input: nums = [1,0,-1,0,-2,2], target = 0
    //Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
    class Program
    {
        static void Main(string[] args)
        {
            Sum4Impl impl = new Sum4Impl();
            var result = impl.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
        }
    }
}
//-2, -1, 0, 0, 1, 2