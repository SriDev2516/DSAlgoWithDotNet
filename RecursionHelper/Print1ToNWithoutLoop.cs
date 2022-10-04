using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionHelper
{
    public class Print1ToNWithoutLoop
    {
        public void Print(int n)
        {
            if(n <1)
            {
                return;
            }
            Print(n - 1);
            Console.Write(n + " ");
        }
    }
}
