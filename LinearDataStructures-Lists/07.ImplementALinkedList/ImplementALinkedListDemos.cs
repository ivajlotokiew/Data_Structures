namespace _07.LinkedList
{
    using System;

    public static class ImplementALinkedListDemos
    {
        public static void Main()
        {
            var linked = new SimpleLinkedList<int>();

            linked.Add(1);
            linked.Add(2);
            linked.Add(3);
            linked.Add(1);
            var fourNode = linked.Add(4);
            Console.WriteLine("Four node: " + fourNode.Value);

            Console.WriteLine(linked.Count);
            Console.WriteLine("First index of 1 is: " + linked.FirstIndexOf(1));
            Console.WriteLine("Last index of 1 is: " + linked.LastIndexOf(1));

            Console.WriteLine("------------");
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }

            linked.Remove(0);

            Console.WriteLine("------------");
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
        }
    }
}
