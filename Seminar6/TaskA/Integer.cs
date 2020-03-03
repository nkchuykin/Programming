using System;
public struct Integer
{
    int intValue;

    public Integer(int value = 0)
    {
        intValue = value;
    }

    public int Value
    {
        get
        {
            return intValue;
        }

        set
        {
            intValue = value;
        }
    }

    public Integer this[int index]
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
