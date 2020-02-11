using System;

namespace TaskF
{
    class Program
    {
        static void Main(string[] args)
        {
            StrangeQueue strangeQueue = new StrangeQueue();

            while (true)
            {
                string action = Console.ReadLine();
                switch (action)
                {
                    case "GL":
                        try
                        {
                            Customer customer = new Customer(Console.ReadLine());
                            strangeQueue.GetInLine(customer);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e is ArgumentException ? e.Message : string.Empty);
                        }
                        break;
                    case "C":
                        try
                        {
                            Console.WriteLine(strangeQueue.Call());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e is InvalidOperationException ? e.Message : string.Empty);
                        }
                        break;
                    case "LL":
                        try
                        {
                            Console.WriteLine(strangeQueue.LastInLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e is InvalidOperationException ? e.Message : string.Empty);
                        }
                        break;
                    default:
                        return;
                }
            }
        }
    }
}