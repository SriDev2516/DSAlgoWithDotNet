using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionHelper
{
    class ReverseOfAnArray
    {
        public int[] FindReverse(int[] arr)
        {
            if (arr.Length <= 1) return arr;
            int mid = arr.Length / 2;
            Swap(arr, 0);
            return arr; //-1, 4, 5, 6, 0, 3, 5
        }

        private void Swap(int[] arr, int i)
        {
            if (i > arr.Length / 2) return;

            int temp = arr[arr.Length - i -1];
            arr[arr.Length - i - 1] = arr[i];
            arr[i] = temp;

            Swap(arr, i + 1);

        }
    }
}
