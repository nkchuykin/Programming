public class LinkedListNode
{
    public static LinkedListNode NIL;

    public int Number { get; set; }

    public LinkedListNode Next { get; set; }

    static LinkedListNode()
    {
        NIL = new LinkedListNode();
        NIL.Next = NIL;
    }

    public LinkedListNode(int number = 0, LinkedListNode parent = null)
    {
        Number = number;
        if (parent != null)
            parent.Next = this;
        Next = NIL;
    }
}
