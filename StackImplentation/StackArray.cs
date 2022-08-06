using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplentation
{
    public class StackArray
    {
        private const int SIZE = 5;
        int[] array;
        int top = -1;
        public StackArray()
        {
            array = new int[SIZE];
        }

        public void push(int data)
        {
            if (top == SIZE - 1)
            {
                Display("The stack is full and cannot insert new items");
                return;
            }
            else
            {
                ++top;
                array[top] = data;
            }
        } 

        public void pop()
        {
            if (top == -1)
            {
                Display("The stack is empty");
            }
            else
            {
                top--;
            }
        }

        public void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void Print()
        {
            if (top == -1)
            {
                Display("Array is empty");
            }
            else
            {
                for (int i = 0; i < top; i++)
                {
                    Display(array[i].ToString());
                }
            }
        }
    }
}
