using System;


class Program
{
    public static void Main(string[] args)
    {
        Vector a = new Vector(Console.ReadLine());
        Vector b = new Vector(Console.ReadLine());
        Console.WriteLine(a.GetLength().ToString("F3"));
        Console.WriteLine(a.Multiply(2));
        Console.WriteLine(a.DotProduct(b).ToString("F3"));
        Console.WriteLine(a.CrossProduct(b).ToString("F3"));
    }
}