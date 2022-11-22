using System;
using System.Collections.Generic;

namespace PrintBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();
            print.PrintWithInbuiltFunction(6);
            print.PrintWithQueue(6);
        }
    }

    public class Print
    {
        public void PrintWithInbuiltFunction(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{Convert.ToString(i, 2)}");
            }
        }

        public void PrintWithQueue(int n)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            for (int i = 1; i <= n; i++)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(i*10);
                queue.Enqueue(i*10+1);
            }
        }
    }
}
