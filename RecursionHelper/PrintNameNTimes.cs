using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionHelper
{
    public class PrintNameNTimes
    {
        private int _num;
        public PrintNameNTimes(int num)
        {
            _num = num;
        }

        public void PrintName(string name)
        {
            
            if (_num <= 0) return;
            Console.WriteLine(name);
            _num--;
            PrintName(name);
            
        }
    }
}
