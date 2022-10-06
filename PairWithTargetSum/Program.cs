using System;

namespace PairWithTargetSum
{
    class Program
    {
        static void Main(string[] args)
        {
        //Mainly used if the array is sorted.
        //Given an array of sorted numbers and a target sum,
        //find a pair in the array whose sum is equal to the given target.

        //Input:[1, 2, 3, 4, 6], target = 6
        //Output:[1, 3]
        //Explanation: The numbers at index 1 and 3 add up to 6: 2 + 4 = 6

            var result = FindThePairWithTargetSum(new int[] { 1, 2, 3, 4, 5, 6 }, 6);
        }

        private static int[] FindThePairWithTargetSum(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length -1;
            

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[left]  + arr[right] == target)
                {
                    return new int[] { arr[left], arr[right] };
                }

                if(arr[left] + arr[right] > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return new int[2]; 
        }
    }
}
