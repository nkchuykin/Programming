using System;

public class Rat : ICloneable
{
    public Rat(int v)
    {
    }

    public object Clone()
    {
        throw new NotImplementedException();
    }

    internal int GetTailLength()
    {
        throw new NotImplementedException();
    }

    internal void Mutate(int v)
    {
        throw new NotImplementedException();
    }
}
