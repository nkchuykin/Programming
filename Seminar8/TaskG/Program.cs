using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        API api = new API();
        string request = Console.ReadLine();
        double speed = double.Parse(Console.ReadLine());
        List<int> requested = Handler.Handle(api.Request(request), speed);
        foreach (int a in requested)
            Console.Write(a + " ");
    }
}