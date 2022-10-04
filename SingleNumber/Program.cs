using System;
using System.Collections.Generic;

namespace SingleNumber
{
    class Program
    {
        //In a non-empty array of integers,
        //every number appears twice except for one, find that single number.

        //Input: 1, 4, 2, 1, 3, 2, 3
        // Output: 4

        static void Main(string[] args)
        {
            Console.WriteLine(FindSingleNumber(new int[] { 1, 4, 2, 1, 3, 2, 3 }));
            
        }

        private static int FindSingleNumber(int[] nums)
        {
            return -1;
        }
    }
}
