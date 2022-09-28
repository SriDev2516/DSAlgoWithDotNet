using System;
using System.Collections.Generic;
using System.Text;

namespace FindMissingNumberInArray
{
    public class FindSingleNumber
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

        public static int FindSingleNumberUsingXOR(int[] arr)
        {
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                num = num ^ arr[i];
            }

            return num;
        }
    }
}
