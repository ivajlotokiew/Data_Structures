namespace _07.LinkedList
{
    using Interfaces;

    public class SimpleLinkedListNode<T> : ISimpleLinkedListNode<T>
    {
        public SimpleLinkedListNode(T value)
        {
            this.Value = value;
        }

        public ISimpleLinkedListNode<T> Next { get; set; }

        public T Value { get; }
    }
}