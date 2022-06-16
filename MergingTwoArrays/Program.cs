// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var arr1 = new int[] { 1, 3, 4, 5 };
var arr2 = new int[] { -9, -1, 2, 3, -3 };
mergeArrays(arr1, arr2, arr1.Length, arr2.Length);


static void mergeArrays(int[] arr1, int[] arr2, int arr1Size, int arr2Size)
{
    int[] arr3 = new int[arr1Size + arr2Size];  // creating a new array
                                                // Write your cod e here
    int i = 0; int j = 0; int k = 0;

    while (i < arr1Size && j < arr2Size)
    {
        if (arr1[i] < arr2[j])
        {
            arr3[k++] = arr1[i++];
        }
        else
        {
            arr3[k++] = arr2[j++];
        }
    }
    
    while(i< arr1Size)
        {
            arr3[k++] = arr1[i++];
        }

        while (j < arr2Size)
        {
            arr3[k++] = arr2[j++];
        }


    foreach (var item in arr3)
    {
        Console.WriteLine(item);
    }
}