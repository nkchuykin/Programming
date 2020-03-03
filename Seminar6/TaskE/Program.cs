using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Queue<string> queue = new Queue<string>();
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split(' ');
            switch(commands[0])
            {
                case "+":
                    queue.Enqueue(commands[1]);
                    break;
                case "-":
                    Console.WriteLine(queue.Dequeue());
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
