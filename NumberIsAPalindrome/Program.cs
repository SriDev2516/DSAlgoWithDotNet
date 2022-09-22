using System;
using System.Collections;
using System.Collections.Generic;

namespace NumberIsAPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
        }

        public static bool IsPalindrome(int num)
        {
            if(num < 0) return false;
            int x = num;
            int revertedNumber = 0;
            int remainder = 0;

            while(x > 0)
            {
                remainder = x % 10;
                revertedNumber = 10 * revertedNumber + remainder;
                x = x / 10;
            }

            return revertedNumber == num;
        }
    }
}
