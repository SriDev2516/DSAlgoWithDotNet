using System;

namespace FlipAMatrix
{
    internal class FlipArray
    {
        internal static object Flip(int[,] arr)
        {
            int R = arr.GetLength(0);

            for (int row = 0; row < R; row++)
            {
                for (int col = 0; col < (R+1)/2; col++)
                {
                    var temp = arr[row, col] ^ 1;
                    arr[row, col] = arr[row, R - col - 1] ^ 1;
                    arr[row, R - col - 1] = temp;
                }
            }

            return arr;
        }
    }
}