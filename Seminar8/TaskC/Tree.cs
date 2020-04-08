using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class Tree : IComparable<Tree>
{
    public int height;
    public int age;

    public Tree(int height, int age)
    {
        throw new NotImplementedException();
    }

    public int CompareTo(Tree other)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}