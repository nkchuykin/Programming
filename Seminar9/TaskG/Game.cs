using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

internal class Game : IEnumerable<string>
{
    private LinkedList<int> first;
    private LinkedList<int> second;

    public Game(LinkedList<int> first, LinkedList<int> second)
    {
        this.first = first;
        this.second = second;
    }

    public IEnumerator<string> GetEnumerator()
    {
        throw new NotImplementedException();

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}