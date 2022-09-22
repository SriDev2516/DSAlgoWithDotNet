using System;

namespace _643
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
        }

        public static double FindMaxAverage(int[] arr, int K)
        {
            double[] result = new double[arr.Length - K + 1];
            double windowSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd]; // add the next element
                                             // slide the window, we don't need to slide if we've not hit the required window size of 'k'
                if (windowEnd >= K - 1)
                {
                    result[windowStart] = windowSum / K; // calculate the average
                    windowSum -= arr[windowStart]; // subtract the element going out
                    windowStart++; // slide the window ahead
                }
            }

            Array.Sort(result);
            return result[result.Length - 1];
        }
    }
}
