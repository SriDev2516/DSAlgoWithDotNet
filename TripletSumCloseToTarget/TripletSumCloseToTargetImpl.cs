using System;
using System.Collections.Generic;
using System.Text;

namespace TripletSumCloseToTarget
{
    public class TripletSumCloseToTargetImpl
    {
        public int FindTheTripletSumCloseToTarget(int[] arr, int target)
        {
            int min_gap = int.MaxValue;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length -2; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;

                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];
                    if(sum == target)
                    {
                        return target;
                    }
                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }

                    if(Math.Abs(min_gap - target) > Math.Abs(sum - target))
                    {
                        min_gap = sum;
                    }
                }
            }
            return min_gap;
        }
    }
}
