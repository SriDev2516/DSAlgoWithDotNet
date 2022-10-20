using System;
using System.Collections.Generic;

namespace TripletSumToZero
{
    public class TripletSumToZeroImpl
    {
        List<int[]> list;
     
        public List<int[]> FindTriplet(int[] arr)
        {
            list = new List<int[]>();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i] == arr[i-1])
                {
                    continue;
                }
                SearchPair(arr, -arr[i], i + 1);
            }

            return list;
          
        }

        private void SearchPair(int[] arr, int target, int left)
        {
            int right = arr.Length - 1;
            while(left < right)
            {
                int target_sum = arr[left] + arr[right];

                if(target == target_sum)
                {
                    list.Add(new int[] { -target, arr[left], arr[right] });
                    left++;
                    right--;
                }
                else if(target_sum > target)
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
}