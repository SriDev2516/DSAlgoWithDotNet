using System;

namespace InsertAtPositionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayDemo arrDemo = new ArrayDemo();
            var tempArr = new int[] { 2, 3, 4, 6, 7, 9, 10 };
            //arrDemo.DisplayArray(tempArr);
            arrDemo.InsertAtPosition(tempArr, 0, tempArr.Length, 1);
        }
    }
}
