using System;
using System.Collections.Generic;

namespace TripletSumToZero
{
    internal class DisplayData
    {
        public static void Display(List<int[]> list)
        {
            foreach (var arr in list)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}