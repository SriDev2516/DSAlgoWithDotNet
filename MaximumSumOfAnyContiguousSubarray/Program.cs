using System;

namespace MaximumSumOfAnyContiguousSubarray
{
    class Program
    {
        //Given an array of positive numbers and a positive number ‘k,’ find the maximum sum of any contiguous subarray of size ‘k’.

        //Input: [2, 1, 5, 1, 3, 2], k=3 
        //Output: 9
        //Explanation: Subarray with maximum sum is [5, 1, 3].
        static void Main(string[] args)
        {
            MaximumSum obj = new MaximumSum();
            var result1= obj.FindMaximumSum(new int[] { 2, 1, 5, 1, 3, 2 }, 3);
            var result2= obj.FindMaximumSum(new int[] { 2, 3, 4, 1, 5 }, 2);
        }
    }
}
