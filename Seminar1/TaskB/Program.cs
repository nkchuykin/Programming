using System;
class Program
{
    static void Main(string[] args)
    {

        try
        {
            Programmer programmer1 = new Programmer(int.Parse(Console.ReadLine()));
            Programmer programmer2 = new Programmer(int.Parse(Console.ReadLine()));

            Console.WriteLine(programmer1.CompareTo(programmer2));
            Console.WriteLine(Programmer.CompareTo(programmer1, programmer2));
            Console.WriteLine(Programmer.CompareTo(programmer1, programmer2,
                int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.GetType());
        }

    }
}


