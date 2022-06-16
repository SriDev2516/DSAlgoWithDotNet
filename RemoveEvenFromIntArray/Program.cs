// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var arr = new int[] { 1, 2, 3, 7, 10, 12, 34, 54, 79, 91 };


Console.WriteLine(removeEvenNumbersFromArr(arr, arr.Length));

Console.ReadLine(); 

static int[] removeEvenNumbersFromArr(int[] arr, int size)
{
    int m = 0;

    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 != 0)
        {
            arr[m] = arr[i];
            m++;
        }
    }

    var temp = new int[m];
    for (int i = 0; i < m; i++)
    {
        temp[i] = arr[i];
    }

    arr = temp;

    return arr;
}
        