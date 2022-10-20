using System;

namespace MaximumSumOfAnyContiguousSubarray
{
    internal class MaximumSum
    {
        public MaximumSum()
        {
        }

        //Input: [2, 1, 5, 1, 3, 2], k=3 
        internal int[] FindMaximumSum(int[] arr, int k)
        {
            int[] result = new int[k];
            int maxIndex = 0;
            int maxSum = 0;
            int startWindow = 0;
            int sum = 0;
            int target = k;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if(i== k - 1)
                {
                   if(sum > maxSum) 
                    {
                        maxSum = sum;
                        maxIndex = startWindow;
                    }
                    sum = sum - arr[startWindow];
                    startWindow++;
                    k++;
                }
            }

             Array.Copy(arr, maxIndex, result, 0, target);

            return result;
        }
    }
}