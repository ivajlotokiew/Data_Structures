namespace Problem_1.Find_the_Root
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int nodes = int.Parse(Console.ReadLine());
            int edges = int.Parse(Console.ReadLine());
            int counter = 0;
            int index = 0;

            bool[] isTree = new bool[nodes];

            for (int i = 0; i < edges; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');

                isTree[int.Parse(edge[1])] = true;
            }

            for (int i = 0; i < nodes; i++)
            {
                if (isTree[i] == false)
                {
                    counter++;
                    index = i;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No root!");
            }
            else if (counter == 1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Multiple root nodes!");
            }
        }
    }
}
