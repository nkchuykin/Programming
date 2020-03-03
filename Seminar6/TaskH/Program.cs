using System;

class MainClass
{
    public static void Main(string[] args)
    {
        HashTable<string> hashTable = new HashTable<string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split(' ');
            bool flag;
            switch(commands[0])
            {
                case "+":
                    flag = hashTable.Add(commands[1]);
                    break;
                case "-":
                    flag = hashTable.Remove(commands[1]);
                    break;
                case "?":
                    flag = hashTable.Find(commands[1]);
                    break;
                default:
                    throw new NotImplementedException();
            }
            if (flag)
                Console.WriteLine("Succsess");
            else
                Console.WriteLine("FAIL");
        }
    }
}
