using System;

class MainClass
{

    public static void Main(string[] args)
    {
        Rat firstRat = new Rat(int.Parse(Console.ReadLine()));
        Rat secondRat = RatIncubator.CloneRat(firstRat);
        secondRat.Mutate(int.Parse(Console.ReadLine()));
        Console.WriteLine(firstRat.GetTailLength());
        Console.WriteLine(secondRat.GetTailLength());
    }
}
