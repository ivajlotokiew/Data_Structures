namespace Problem_1.Find_the_Root
{
    using System.Collections.Generic;

    public class Tree<T>
    {
        public Tree(T value)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
        }

        public T Value { get; set; }

        public Tree<T> Parent;

        public IList<Tree<T>> Children { get; set; }
    }
}