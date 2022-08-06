using System;

namespace StackImplentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackWithList stack = new StackWithList();

            stack.Push(12);
            stack.Push(13);
            stack.Push(14);

            stack.Print();

            stack.Pop();

            stack.Print();
        }
    }
}
