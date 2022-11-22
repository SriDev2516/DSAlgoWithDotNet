using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionHelper
{
    public class PerfectSumProblem
    {
        internal int PrintSum(int index, int[] arr, List<int> result,  int sum, int target, int n)
        {
            if (index >= n)
            {

                int max = result.Max();
                int min = result.Min();
                if(result.Count > 0 && (max + min <= target))
                {
                    foreach (var item in result)
                    {
                        Console.Write(item + ", ");
                    }
                    Console.WriteLine();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

          
            sum += arr[index];
            result.Add(arr[index]);
            int lh = PrintSum(index + 1, arr, result, sum, target, n);

            result.RemoveAt(result.Count - 1);
            sum -= arr[index];

            int rh = PrintSum(index + 1, arr, result,  sum, target, n);

            return lh+rh;
        }
    }
}
