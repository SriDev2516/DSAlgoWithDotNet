using System;

namespace TripletSumCloseToTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            TripletSumCloseToTargetImpl tripletSumCloseToTargetImpl = new TripletSumCloseToTargetImpl();
            Console.WriteLine(tripletSumCloseToTargetImpl.FindTheTripletSumCloseToTarget(new int[] { -2, 0, 1, 2 }, 2));
            Console.WriteLine(tripletSumCloseToTargetImpl.FindTheTripletSumCloseToTarget(new int[] { -3, -1, 1, 2 }, 1));
            Console.WriteLine(tripletSumCloseToTargetImpl.FindTheTripletSumCloseToTarget(new int[] { 1, 0, 1, 1 },100));
        }
    }
}
