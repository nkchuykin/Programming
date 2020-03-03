using System;

public delegate int HashFunc<T>(T element);

public class HashTable<TKey>
{

    int size;
    int filled = 0;

    private HashTableNode<TKey>[] elements;

    public HashTable(int size = 8)
    {
        throw new NotImplementedException();
    }

    private void Resize()
    {
        throw new NotImplementedException();
    }

    public bool Add(TKey element)
    {
        throw new NotImplementedException();
    }

    public bool Remove(TKey element)
    {
        throw new NotImplementedException();
    }

    public bool Find(TKey element)
    {
        throw new NotImplementedException();
    }

}
