namespace Problem_6.Implement_ReversedList
{
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public class ReversedList<T> : IEnumerable<T>
    {
        private const uint DefaultArrayCapacity = 16;
        private uint arrayCapacity;

        private T[] array;

        public ReversedList(uint capacity = DefaultArrayCapacity)
        {
            this.array = new T[capacity];
            this.ArrayCapacity = capacity;
            this.ArrayCount = 0;
        }

        public uint ArrayCapacity
        {
            get
            {
                return this.arrayCapacity;
            }

            private set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.arrayCapacity = value;
            }
        }

        public int ArrayCount { get; private set; }

        public void Add(T item)
        {
            if (this.ArrayCount == this.ArrayCapacity)
            {
                DoubleIncreaseCollectionLength();
            }

            this.array[this.ArrayCount] = item;
            this.ArrayCount++;
        }

        private void DoubleIncreaseCollectionLength()
        {
            T[] copyArray = new T[this.ArrayCapacity * 2];
            Array.Copy(this.array, copyArray, this.ArrayCount);

            this.array = copyArray;
            this.ArrayCapacity *= 2;
        }

        public uint Capacity()
        {
            return this.ArrayCapacity;
        }

        public int Count()
        {
            return this.ArrayCount;
        }

        public void Remove(int index)
        {
            if (index <= 0 || index >= this.ArrayCount)
            {
                throw new IndexOutOfRangeException();
            }

            int indexToRemove = this.ArrayCount - (index + 1);

            for (int i = indexToRemove + 1; i <= this.ArrayCount; i++)
            {
                this.array[indexToRemove] = this.array[i];
                indexToRemove++;
            }

            this.array[this.ArrayCount] = default(T);
            this.ArrayCount--;
        }

        public T this[int number]
        {
            get
            {
                if (number >= 0 && number < this.ArrayCount)
                {
                    return this.array[this.ArrayCount - (number + 1)];
                }
                else
                {
                    throw new ArgumentException("Wrong index");
                }
            }

            set
            {
                if (number >= 0 && number < this.ArrayCount)
                {
                    this.array[this.ArrayCount - (number + 1)] = value;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.ArrayCount - 1; i >= 0; i--)
            {
                yield return this.array[i];
            }
        }

        public override string ToString()
        {
            return String.Join(" ", this.array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}