using System;

namespace ComplementOfBase10
{
    class Program
    {
        static void Main(string[] args)
        {
        //For a given positive number N in base - 10, return the complement of its binary
        //representation as a base - 10 integer.

        //Input: 8
        //Output: 7
        //Explanation: 8 is 1000 in binary, its complement is 0111 in binary,
        //which is 7 in base - 10.
        var result = FindComplementOfBase10(8);
        Console.WriteLine(result);
        }

        private static int FindComplementOfBase10(int v)
        {
            int num = v;
            int numberofbits = 0;
            while(num > 0)
            {
                num = num >> 1;
                numberofbits++;
            }

            int all_set_bits = (int)Math.Pow(2, numberofbits) - 1;

            return all_set_bits ^ v;
        }
    }
}
