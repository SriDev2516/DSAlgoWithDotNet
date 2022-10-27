using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionHelper
{
    class FactorialOfANumber
    {
        List<long> list = new List<long>();
        public int FindFactorial(int n)
        {
            int m = n;
            if (n == 1 || n == 0) return 1;
            if(n < m)
                list.Add(n);
            return  n * FindFactorial(n - 1);
        }

        public List<long> FindListOfFactorialLessThanN(long n)
        {
            long count = 1;
            while (count <= n)
            {
                long fact = FindFactorial(count);
                if (fact > n)
                    break;
                list.Add(fact);
                count++;
            }
            return list;
        }

        public long FindFactorial(long n)
        {
            if (n == 1 || n == 0) return 1;
            return n * FindFactorial(n - 1);
        }
    }
}
