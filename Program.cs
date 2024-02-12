using System;
using Algos;
public class Program
{
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 10;
        LinearSearch<int> search = new(arr, x);
        int result = search.SearchElement();

        Console.Write(result == -1 ? "Element not found!" : $"{x} found at index {result}!");
    }
}
