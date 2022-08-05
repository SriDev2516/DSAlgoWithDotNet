using System;

namespace SearchAnElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 7, 9, 6, 5, 2, 1, 7 };
            var index = ArraySearchDemo.SearchArray(arr, 6);
            Console.WriteLine( index == -1 ? $"Element not found" : $"Element is Prsent in the array and the index is {index}" );
        }
    }

    public class ArraySearchDemo
    {
        public static int SearchArray(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
