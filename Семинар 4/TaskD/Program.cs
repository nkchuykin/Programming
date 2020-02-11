using System;

class Program
{
    static void Main(string[] args)
    {
        Release firstApp = new Release("v1.0");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split();
            switch (commands[0])
            {
                case "NEW":
                    Release.MakeRelease(commands[1], commands[2]);
                    break;
                case "ADD":
                    Release.AddBugToRelease(commands[1], commands[2]);
                    break;
                case "FIX":
                    Bug.FixBug(commands[1]);
                    break;
                case "COUNT":
                    Console.WriteLine(Release.CountBugAmount(commands[1]));
                    break;
                default:
                    throw new ArgumentException("Unknown command");
            }
        }
    }
}
