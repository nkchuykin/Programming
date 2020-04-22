using System;

class Program
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(x.Max(y));
        Console.WriteLine(x.ToString().Max(y.ToString()));
    }
}