using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public static class UtilityService
    {
        public static void DisplayArray(int[] arr)
        {
            StringBuilder sb = new StringBuilder("[");
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
                if (i < arr.Length - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]");

            Console.WriteLine(sb.ToString());
        }
    }
}
