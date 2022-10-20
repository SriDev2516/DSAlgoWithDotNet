using System;

namespace SumOfFirstNTerms
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var result = sumOfSeries(5);
        }

        static long sumOfSeries(long N)
        {
            // code here
            long sum = 0;
            if (N == 0) return sum;
          
            sumOfSeries(N - 1);
            sum += (N * N * N);
            return sum;
        }
    }
}
