using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{ 
    static void Main(string[] args)
    {
        LinkedList<int> first = new LinkedList<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        LinkedList<int> second = new LinkedList<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

        Game game = new Game(first, second);
        foreach (var str in game)
        {
            Console.WriteLine(str);
        }
    }
}