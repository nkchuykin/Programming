using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        List<int> list = new List<int>(input);
        IEnumerable<int> even = new OnlyEven(list);
        Console.WriteLine(String.Join(" ", even));
    }
}