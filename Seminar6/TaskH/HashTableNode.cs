using System;

public class HashTableNode<TKey>
{
    private TKey key;
    private HashTableNodeCondition condition = HashTableNodeCondition.Inactive;

    public TKey Key
    {
        get
        {
            return key;
        }

        set
        {
            this.key = value;
        }
    }

    public HashTableNodeCondition Condition
    {
        get
        {
            return condition;
        }
        set
        {
            this.condition = value;
        }
    }
}
