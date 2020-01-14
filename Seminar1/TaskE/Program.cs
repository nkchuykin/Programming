using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        String str1 = Console.ReadLine();
        Console.WriteLine(str1.IsPalindrome());

        Dictionary<Char, Int32> dictionary = str1.CountLatinSymbols();
        foreach (var item in dictionary)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }

        String str2 = Console.ReadLine();
        try
        {
            Console.WriteLine(str2.ToInt());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.GetType());
        }
    }
}

