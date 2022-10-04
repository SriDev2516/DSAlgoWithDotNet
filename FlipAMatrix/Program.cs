using System;

namespace FlipAMatrix
{
    //Given a binary matrix representing an image, we want to flip the image horizontally,
    //then invert it.

//    Input: [
//  [1,0,1],
//  [1,1,1],
//  [0,1,1]
//]
//Output: [
//  [0,1,0],
//  [0,0,0],
//  [0,0,1]
//]
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,]
            {
                {1,0,1 },
                {0,0,1 },
                {1,0,1 }
            };
            var result = FlipArray.Flip(arr);
        }
    }
}
