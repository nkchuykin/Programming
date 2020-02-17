public interface IList
{
    void Push(int number);

    int this[int index] { get; set; }

    void RemoveAt(int position);
}
