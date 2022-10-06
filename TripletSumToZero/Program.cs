using System;
using System.Collections.Generic;

namespace TripletSumToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = new int[] { -3, 0, 1, 2, -1, 1, -2 };
            var input2 = new int[] { -5, 2, -1, -2, 3 };
            TripletSumToZeroImpl impl = new TripletSumToZeroImpl();
            DisplayData.Display(impl.FindTriplet(input1));
            Console.WriteLine("*************************************");
            DisplayData.Display(impl.FindTriplet(input2));
            
        }

       
    }

   
}
