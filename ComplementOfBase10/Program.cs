using System;

namespace ComplementOfBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FindComplementOfBase10(0);
        }


        private static int FindComplementOfBase10(int num)
        {
            int numOfBits = 0;
            while(num >= 0)
            {
                numOfBits++;
                num = num >> 1;
            }

            int all_bits_set = (int)Math.Pow(2, numOfBits) - 1;


            return num * all_bits_set;
        }
    }
}
