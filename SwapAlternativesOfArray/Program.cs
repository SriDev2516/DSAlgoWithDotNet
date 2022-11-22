using System;

namespace SwapAlternativesOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 9, 3, 6 ,12 ,4, 32, 56 };
            SwapAlternatives(arr);
            print(arr);
        }

        private static void print(int[] arr)
        {
           foreach(int num in arr)
            {
                Console.Write(num + ", ");
            }
        }

        private static void SwapAlternatives(int[] arr)
        {
            for(int i=1; i< arr.Length; i+=2)
            {
                int temp = arr[i];
                arr[i] = arr[i-1];
                arr[i-1] = temp;
            }
            
        }



      
    }
}
