using System;

namespace AverageOfEachSubarrayOfK
{
    class Program
    {
        //Given an array, find the average of each subarray of ‘K’ contiguous elements in it.
        //Array: [1, 3, 2, 6, -1, 4, 1, 8, 2], K=5
        // Output: [2.2, 2.8, 2.4, 3.6, 2.8]
        static void Main(string[] args)
        {
            AverageOfSubArray averageOfSubArray = new AverageOfSubArray();

            var result = averageOfSubArray.FindAverage(new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5);
        }
    }
}
