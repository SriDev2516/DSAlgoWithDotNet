using System;
using System.Collections.Generic;
using System.Text;

namespace FindMissingNumberInArray
{
    public class FindMIssingNumber
    {
        public static int FindSingleNumberUsingDictionary(int[] arr)
        {
            Dictionary<int, int> data = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!data.ContainsKey(arr[i]))
                {
                    data[arr[i]] = 1;
                }
                else
                {
                    data[arr[i]] = data[arr[i]] + 1;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (data[arr[i]] == 1)
                {
                    return arr[i];
                }
            }

            return -1;
        }

    }
}
