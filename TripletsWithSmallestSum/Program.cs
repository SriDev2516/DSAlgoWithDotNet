using System;

namespace TripletsWithSmallestSum
{
    class Program
   {
        //Given an array arr of unsorted numbers and a target sum, count all triplets in it such that arr[i] + arr[j] + arr[k] < target where i, j, and k are three different indices
        //Write a function to return the count of such triplets.

        //Input: [-1, 0, 2, 3], target=3 
        //Output: 2
        //Explanation: There are two triplets whose sum is less than the target: [-1, 0, 3], [-1, 0, 2]
        static void Main(string[] args)
        {
            SmallestSumTriplets smallestSumTriplets = new SmallestSumTriplets();
            var count = smallestSumTriplets.FindTheSum(new int[] { -1, 4, 2, 1, 3 }, 5);
        }
    }
}
