using System;
using System.Collections.Generic;

namespace TripletSumToZero
{
    class Program
    {
        static List<int[]> list = new List<int[]>();
        static void Main(string[] args)
        {
            var arr = new int[] { -5, 2, -1, -2, 3 };
            Array.Sort(arr);
            FindTripletSumToZeroFunc(arr);
            foreach (var item in list)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i] + ", ");
                }
                Console.WriteLine();
            }
        }

        private static void  FindTripletSumToZeroFunc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i] == arr[i-1])
                {
                    continue;
                }
                search_pair(arr, -arr[i], i + 1);
            }
            
            
        }

        private static void search_pair(int[] arr, int target, int left)
        {
            int right = arr.Length - 1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target)
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
