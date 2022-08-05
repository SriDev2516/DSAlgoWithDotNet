using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace InsertAtPositionDemo
{
    public class ArrayDemo
    {
        public void InsertAtPosition(int[] arr, int position, int size, int element)
        {
            var newArray = new int[size + 1];
            
            for(int i = 0; i < size; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = newArray.Length-1; i > position; i--)
            {
                newArray[i] = newArray[i - 1];
            }

            newArray[position] = element;
            UtilityService.DisplayArray(newArray);
        }
    }
}
