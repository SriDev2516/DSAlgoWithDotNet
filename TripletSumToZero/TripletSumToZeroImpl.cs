using System;
using System.Collections.Generic;
using System.Text;

namespace TripletSumToZero
{
    public class TripletSumToZeroImpl
    {
        List<int[]> list = new List<int[]>();

       
        public List<int[]> FindTriplet(int[] arr)
        {
            try
            {
                list.Clear();
                Array.Sort(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Search_TripLet_Pair(arr, -arr[i], i + 1);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                //list.Clear();
            }
           
        }

        private void Search_TripLet_Pair(int[] arr, int target, int left)
        {
            var right = arr.Length - 1;

            while (left < right)
            {
                var sum = arr[left] + arr[right];
                if (sum  == target)
                {
                    list.Add(new int[] { -target, arr[left], arr[right] });
                    left++;
                    right--;
                }
                else if(sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
    }
}
