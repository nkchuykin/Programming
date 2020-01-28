using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static Dictionary<string, User> userDB = new Dictionary<string, User>();

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        User[] users = new User[n];
        for (int i = 0; i < n; i++)     // создаем пользователей
        {
            string username = Console.ReadLine();
            users[i] = new User(username);
            userDB[username] = users[i];
        }
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string[] command = Console.ReadLine().Split(' ');
            switch(command[0])
            {
                case "subscribe":
                    userDB[command[1]].Subscribe(command[2]);
                    break;
                case "Unsubscribe":
                    userDB[command[1]].Unsubcribe(command[2]);
                    break;
                case "message":
                    userDB[command[1]].SendMessage(command[2]);
                    break;
                default:
                    throw new KeyNotFoundException();
            }
        }
        foreach(User user in users)
            Console.WriteLine(user);
    }
}

