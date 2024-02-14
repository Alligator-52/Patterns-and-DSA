using System;
using Algos;
public class Program
{
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10,5, 40 };
        int x = 10;
        LinearSearch<int> linearSearch = new(arr, x);
        BinarySearch<int> binarySearch = new(arr, x);
        //int result = linearSearch.SearchHashedElement();
        int result = binarySearch.Search();

        Console.Write(result == -1 ? "Element not found!" : $"{x} found at index {result}!");
    }
}
