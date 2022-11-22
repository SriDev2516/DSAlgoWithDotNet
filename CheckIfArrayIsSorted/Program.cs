using System;

namespace CheckIfArrayIsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            arraySortedOrNot(new int[] { 10, 20, 30, 40, 50 });
        }

        private static int arraySortedOrNot(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
