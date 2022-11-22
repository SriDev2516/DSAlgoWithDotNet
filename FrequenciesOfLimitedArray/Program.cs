using System;
using System.Collections.Generic;

namespace FrequenciesOfLimitedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            frequencyCount(new int[] { 3,3,3,3 }, 4, 3);
        }


        public static void frequencyCount(int[] arr, int N, int P)
        {
            //Your code here
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!d.ContainsKey(arr[i]))
                {
                    d[arr[i]] = 1;
                }
                else
                {
                    d[arr[i]] = d[arr[i]] + 1;
                }
            }



            for (int i = 1; i <= P; i++)
            {
                int count = 0;
                if (d.ContainsKey(i))
                {
                    count = d[i];
                }
                arr[i - 1] = count;
            }
        }
    }
}
