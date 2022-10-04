using System;

namespace FindSquaresOFASorrtedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FindSquaresOfSortedArray(new int[] {-3,-2,0,1,2 });
        }

        private static int[] FindSquaresOfSortedArray(int[] nums)
        {
            int len = nums.Length;
            int[] squares = new int[len]; 
            int left = 0;
            int right =  len - 1;
            int rightmostindex = len - 1;

            while(left < right)
            {
                int rightsquare = GetSquare(nums[right]);
                var leftsquare = GetSquare(nums[left]);
                if(leftsquare >  rightsquare)
                {
                    squares[rightmostindex] = leftsquare;
                    left++;
                }
                else
                {
                    squares[rightmostindex] = rightsquare;
                    right--;
                }

                rightmostindex--;
            }

            return squares;
        }

        private static int GetSquare(int v)
        {
            return v * v;
        }
    }
}
