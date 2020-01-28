using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class User
{

    public string Name { get; }

    List<string> messages = new List<string>();

    public User(string username)
    {
        throw new NotImplementedException();
    }
    
    public void RecieveMessage(string text)
    {
        throw new NotImplementedException();
    }

    public void SendMessage(string message)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(string username)
    {
        throw new NotImplementedException();
    }

    public void Unsubcribe(string username)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        string line = "Username: " + Name + "\nMessages:\n";
        foreach(string mes in messages)
            line += mes + "\n";
        return line;
    }
}

