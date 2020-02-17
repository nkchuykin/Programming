using System;
using System.Collections;

class MainClass
{

    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split();
            switch (commands[0])
            {
                case "push":
                    list.Push(int.Parse(commands[1]));
                    break;
                case "get":
                    Console.WriteLine("get " + commands[1] + ": " + list[int.Parse(commands[1])]);
                    break;
                case "set":
                    list[int.Parse(commands[1])] = int.Parse(commands[2]);
                    break;
                case "remove":
                    list.RemoveAt(int.Parse(commands[1]));
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        Console.WriteLine("Full list: ");
        foreach (int num in list)
            Console.Write(num + " ");
    }
}

public partial class LinkedList : IEnumerable
{

    public IEnumerator GetEnumerator()
    {
        for (LinkedListNode lln = head; lln != LinkedListNode.NIL; lln = lln.Next)
            yield return lln.Number;
    }
}
