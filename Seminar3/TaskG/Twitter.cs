using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void RecieveMsgDelegate(string text);

static class Twitter
{

    static Dictionary<string, RecieveMsgDelegate> subscriptions = new Dictionary<string, RecieveMsgDelegate>();

    public static void SendMessage(User sender, string text)
    {
        throw new NotImplementedException();
    }
    public static void SelfSubscribe(User user)
    {
        throw new NotImplementedException();
    }

    public static void Subscribe(User user, string login)
    {
        throw new NotImplementedException();
    }

    public static void Unsubscrie(User user, string login)
    {
        throw new NotImplementedException();
    }
}

