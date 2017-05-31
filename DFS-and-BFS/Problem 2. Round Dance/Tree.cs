namespace Problem_2.Round_Dance_Iv4o
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

        public Tree<T> Parent { get; set; }

        public IList<Tree<T>> Children { get; set; }
    }
}
