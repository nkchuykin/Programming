using System;

class Program
{
    static void Main(string[] args)
    {
        JSONReader jsonreader = new JSONReader("input.txt");
        Console.WriteLine(jsonreader.TheSickestStreet);
    }
}

