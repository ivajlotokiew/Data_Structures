namespace _07.LinkedList.Interfaces
{
    using System.Collections.Generic;

    public interface ISimpleLInkedList<T> : IEnumerable<T>
    {
        int Count { get; }

        ISimpleLinkedListNode<T> Add(T element);

        void Remove(int index);

        int FirstIndexOf(T element);

        int LastIndexOf(T element);
    }
}