namespace _07.LinkedList.Interfaces
{
    public interface ISimpleLinkedListNode<T>
    {
        ISimpleLinkedListNode<T> Next { get; set; }

        T Value { get; }
    }
}