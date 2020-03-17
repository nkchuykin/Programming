using System;
using System.Collections.Generic;
using System.IO;

public class Server
{

    private static string RequestInformation(string login, string requestResult)
    {
        return login + "> " + requestResult;
    }

    private static string SignIn(string login, string password, DateTime time)
    {
        throw new NotImplementedException();
    }

    private static string SignOut(string login, DateTime time)
    {
        throw new NotImplementedException();

    }

    public static void ProcessAuthorization(string requestsPath, string requestsResultsPath)
    {
        throw new NotImplementedException();

    }

}
