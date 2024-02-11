using System;
using Algos;
public class Program
{
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 10;
        LinearSearch search = new(arr);
        int result =  search.SearchElement(x);

        Console.Write(result == -1 ? "Element not found!" : $"{x} found in array!");
    }
}
