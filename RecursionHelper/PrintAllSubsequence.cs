using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RecursionHelper
{
    public class PrintAllSubsequence
    {

        IList<IList<int>> ans = new List<IList<int>>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            int n = nums.Length;
            IList<int> result = new List<int>();
           
            int index = 0;

            printF(index, result, nums,  n, ans);

            return ans;

        }

        public void printF(int index, IList<int> result, int[] arr,  int n, IList<IList<int>> ans)
        {
            if (index == n)
            {
                var list = new List<int>();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                if(ans.Count == 0)
                {
                    ans.Add(list);
                }
                foreach(var item in ans)
                {
                    if (!item.Intersect(list).Any())
                    {
                        ans.Add(list);
                    }
                }
                return;
            }

            result.Add(arr[index]);
            printF(index + 1, result, arr, n, ans);
            result.RemoveAt(result.Count - 1);
            printF(index + 1, result, arr, n, ans);
        }


    }
}
