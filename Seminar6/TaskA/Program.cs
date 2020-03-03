using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Integer n = new Integer(inputs[0]);
        Console.WriteLine(n[inputs[1]]);
    }
}
