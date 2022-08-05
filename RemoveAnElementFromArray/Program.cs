using System;
using Utility;

namespace RemoveAnElementFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 3, 5, 7, 8, 1, 10, 19,20 };
            ArrayDemo arrayDemo = new ArrayDemo();
            arrayDemo.RemoveItem(arr, 10);
        }
    }

    public class ArrayDemo
    {
        public void RemoveItem(int[] arr, int element) 
        { 
           var newArray = new int[arr.Length-1];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != element)
                {
                    newArray[count] = arr[i];
                    count++;
                }
            }
            UtilityService.DisplayArray(newArray);
        }
    }
}
