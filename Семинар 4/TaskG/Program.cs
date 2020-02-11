using System;

namespace TaskG
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Storage storage = new Storage(dimensions[0], dimensions[1], dimensions[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                try
                {
                    storage.GetItem(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e is ArgumentException ? e.Message : string.Empty);
                }
            }

            Console.WriteLine(Storage.AmountOfUnsatisfiedCustomers);
        }
    }
}
