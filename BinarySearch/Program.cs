// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var arr = new int[]{ 1, 2, 3, 4, 5, 6, 8, 9, 10, 14, 16, 19, 22, 23, 25, 26, 27, 29, 31, 34, 35, 36, 38, 39, 40, 45, 46, 48, 50, 51,
        52, 57, 59, 60, 61, 63, 67, 68, 69, 71, 75, 76, 77, 79, 81, 82, 83, 86, 87, 88, 90, 92, 93, 94, 95, 96, 98, 99, 100};

Console.WriteLine(binarysearch(arr, arr.Length, 93));

int binarysearch(int[] arr, int n, int k)
{
    // code here
    if (n <= 0)
    {
        return -1;
    }

    int start = 0;
    int end = n - 1;

    while (start <= end)
    {
        int mid = (start + end) / 2;

        var midVal = arr[mid];

        if (midVal == k) { return mid; }

        if (k < arr[mid]) { end = mid - 1; }

        if (k > arr[mid]) { start = mid + 1; }
    }

    return -1;
}