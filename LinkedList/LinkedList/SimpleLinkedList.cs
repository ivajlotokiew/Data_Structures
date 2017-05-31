namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class SimpleLinkedList<T> : IEnumerable<T>
    {
        public class SimpleLinkedListNode<T>
        {
            public SimpleLinkedListNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }

            public SimpleLinkedListNode<T> Next { get; set; }
        }

        private SimpleLinkedListNode<T> head;
        private SimpleLinkedListNode<T> tail;

        public SimpleLinkedList()
        {
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            SimpleLinkedListNode<T> newNode = new SimpleLinkedListNode<T>(item);
            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else if (this.Count == 1)
            {
                this.tail = newNode;
                this.head.Next = this.tail;
            }
            else
            {
                this.tail.Next = newNode;
                this.tail = newNode;
            }

            this.Count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            int currIndex = 0;
            SimpleLinkedListNode<T> currNode = this.head;
            SimpleLinkedListNode<T> prevNode = null;

            if (index == 0)
            {
                this.head = this.head.Next;
                return;
            }

            while (currIndex < index)
            {
                prevNode = currNode;
                currNode = currNode.Next;
                currIndex++;
            }

            // Remove the found element from the list of nodes
            prevNode.Next = currNode.Next;
        }

        public int FirstIndexOf(T item)
        {
            SimpleLinkedListNode<T> currNode = this.head;
            int index = 0;
            while (currNode != null)
            {
                if (currNode.Value.Equals(item))
                {
                    return index;
                }

                index++;
                currNode = currNode.Next;
            }

            return -1;
        }

        public int LastIndexOf(T item)
        {
            SimpleLinkedListNode<T> currNode = this.head;
            int index = 0;
            int lastIndex = -1;
            while (currNode != null)
            {
                if (currNode.Value.Equals(item))
                {
                    lastIndex = index;
                }

                index++;
                currNode = currNode.Next;
            }

            return lastIndex;
        }

        public IEnumerator<T> GetEnumerator()
        {
            SimpleLinkedListNode<T> currNode = this.head;
            while (currNode != null)
            {
                yield return currNode.Value;
                currNode = currNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}