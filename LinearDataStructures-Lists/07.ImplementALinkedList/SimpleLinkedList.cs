namespace _07.LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Interfaces;

    public class SimpleLinkedList<T> : ISimpleLInkedList<T>
    {
        private ISimpleLinkedListNode<T> head;
        private ISimpleLinkedListNode<T> tail;

        public SimpleLinkedList()
        {
            this.Count = 0;
            this.head = null;
            this.tail = null;
        }

        public int Count { get; private set; }

        private ISimpleLinkedListNode<T> this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                var currentIndex = 0;
                var currentNode = this.head;

                while (currentNode != null)
                {
                    if (currentIndex == index)
                    {
                        break;
                    }

                    currentIndex++;
                    currentNode = currentNode.Next;
                }

                return currentNode;
            }
        }

        public ISimpleLinkedListNode<T> Add(T element)
        {
            var newNode = new SimpleLinkedListNode<T>(element);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                this.tail.Next = newNode;
                this.tail = newNode;
            }

            this.Count++;

            return newNode;
        }

        public void Remove(int index)
        {
            var nodeToRemove = this[index];

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var nextNode = nodeToRemove.Next;
                ISimpleLinkedListNode<T> prevNode = null;

                try
                {
                    prevNode = this[index - 1];
                }
                catch (IndexOutOfRangeException)
                {
                }

                if (prevNode == null)
                {
                    this.head = nextNode;
                }
                else
                {
                    prevNode.Next = nextNode;
                }
            }

            this.Count--;
        }

        public int FirstIndexOf(T element)
        {
            var index = 0;
            foreach (var item in this)
            {
                if (item.Equals(element))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public int LastIndexOf(T element)
        {
            var index = 0;
            var indexFound = -1;

            foreach (var item in this)
            {
                if (item.Equals(element))
                {
                    indexFound = index;
                }

                index++;
            }

            return indexFound;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}