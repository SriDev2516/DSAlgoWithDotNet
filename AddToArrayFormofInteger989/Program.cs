using System;
using System.Collections.Generic;
using System.Linq;

namespace AddToArrayFormofInteger989
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = AddToArrayForm(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 1);
        }

        public static IList<int> AddToArrayForm(int[] num, int k)
        {
            int sum = 0;
            int j = num.Length - 1;
            IList<int> list = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i] * (int)Math.Pow(10, j);
                j--;
            }
            sum = sum + k;
            var res = sum.ToString().ToCharArray().ToList();

            int len = sum.ToString().Length;
            while (sum > 0)
            {
                int rem = sum % 10;
                list.Add(rem);
                sum = sum / 10;
            }

            var result =  list.Reverse();

            return result.ToList();
        }
    }
}
