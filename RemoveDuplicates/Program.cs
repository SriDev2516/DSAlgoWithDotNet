using System;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicatesAndReturnArray(new int[] { 2, 3, 3, 3, 6, 9, 9 });
        }

        private static void RemoveDuplicatesAndReturnArray(int[] arr)
        {
            int k = 0;
            int nonduplicate = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] != nonduplicate)
                {
                    k++;
                    nonduplicate = arr[i];
                    arr[k] = arr[i];
                }
               
            }
        }
    }
}
