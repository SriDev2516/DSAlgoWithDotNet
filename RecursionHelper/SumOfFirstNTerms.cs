using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionHelper
{
    class SumOfFirstNTerms
    {
        double sum = 0;
        public double FindSum(int N)
        {
            // code here
           
            if (N == 0) return sum;

            FindSum(N - 1);
            sum += (N * N * N);
           
            return sum;
        }
    }
}
