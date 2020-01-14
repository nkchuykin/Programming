using System;

class Programm
{
    public static void Main(string[] args)
    {
        string[] data = Console.ReadLine().Split(' ');
        Triangle t = new Triangle(double.Parse(data[0]), double.Parse(data[1]));
        Console.WriteLine(t.Hypotenuse.ToString("f3"));
    }
}

