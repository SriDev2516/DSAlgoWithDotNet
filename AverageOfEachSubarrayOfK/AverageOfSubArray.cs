using System;
using System.Collections.Generic;
using System.Text;

namespace AverageOfEachSubarrayOfK
{
    public class AverageOfSubArray
    {
        public double[] FindAverage(int[] arr, int k)
        {
            // 1, 3, 2, 6, -1, 4, 1, 8, 2

            double sum = 0;
            int index = 0;
            double[] result = new double[arr.Length - k + 1];
            for(int i = 0; i< arr.Length; i++)
            {
                sum += arr[i];
                if (i == k-1)
                {
                    result[index] = sum/5;
                    sum = sum - arr[index];
                    k = k + 1;
                    index++;
                }
            }
            return result;
        }
    }
}
