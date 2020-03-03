using System;

internal class Link<T> 
{
    public T value;
    public Link<T> next;

    public Link(T value, Link<T> next = null)
    {
        this.value = value;
        this.next = next;
    }
}