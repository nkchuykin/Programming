using System;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        try
        {
            Space space = new Space();
            for (int i = 0; i < n; i++)
            {
                space.Add(Console.ReadLine());
            }
            for (int i = 0; i < k; i++)
            {
                space.Destroy(Console.ReadLine());
            }
            Console.WriteLine(space);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}


