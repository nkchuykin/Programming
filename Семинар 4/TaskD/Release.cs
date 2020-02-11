using System;
using System.Collections.Generic;

class Release
{

    public void AddBug(string bugName)
    {
        throw new NotImplementedException();
    }

    public int Count
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public Release(string name, Release previous = null)
    {
        throw new NotImplementedException();
    }

    internal static void MakeRelease(string newReleaseName, string parentReleaseName)
    {
        throw new NotImplementedException();
    }

    internal static void AddBugToRelease(string bugName, string releaseName)
    {
        throw new NotImplementedException();
    }

    internal static int CountBugAmount(string releaseName)
    {
        throw new NotImplementedException();
    }
}

