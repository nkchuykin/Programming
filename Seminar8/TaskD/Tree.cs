using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


[Serializable]
public class Tree<T> : ICloneable where T : IComparable
{

    public void Add(T value)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();

    }

    public object Clone()
    {
        throw new NotImplementedException();
    }

}

