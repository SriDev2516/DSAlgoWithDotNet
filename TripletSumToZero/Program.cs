using System;
using System.Collections.Generic;

namespace TripletSumToZero
{
    class Program
    {
        static void Main(string[] args)
        {
        //Given an array of unsorted numbers, find all unique triplets in it that add up to zero.
        //Input:[-3, 0, 1, 2, -1, 1, -2]
        //Output:[-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]
        //Explanation: There are four unique triplets whose sum is equal to zero.
            var input1 = new int[] { -1, -1, 1, 0, 1, 1 };
            var input2 = new int[] { -5, 2, -1, -2, 3 };
            TripletToSumWithListImpl impl = new TripletToSumWithListImpl();
            var result = impl.ThreeSum(input1);
            Console.WriteLine("*************************************");
            var result1 = impl.ThreeSum(input2);

        }

       
    }

   
}
