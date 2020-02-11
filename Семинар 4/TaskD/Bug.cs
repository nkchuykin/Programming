using System;
using System.Collections.Generic;

class Bug
{

    public bool Killed { get; private set; }

    public Bug(string name)
    {
        throw new NotImplementedException();
    }

    internal static void FixBug(string bugName)
    {
        throw new NotImplementedException();
    }
}

