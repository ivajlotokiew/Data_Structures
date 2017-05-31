using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2.Round_Dance_Iv4o
{
    class Program
    {
        static Dictionary<int, IList<Tree<int>>> graph = new Dictionary<int, IList<Tree<int>>>();

        static void Main()
        {
            int friendships = int.Parse(Console.ReadLine());
            int leader = int.Parse(Console.ReadLine());

            ReadInput(friendships);
            int output = DFS(leader);
            Console.WriteLine(output);
        }

        private static int DFS(int leader)
        {
            var stack = new Stack<int>();
            var visited = new HashSet<int>();
            int currCount = 0;
            int maxCount = 0;

            stack.Push(leader);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                visited.Add(currentNode);
                currCount++;

                foreach (var child in graph[currentNode])
                {
                    if (!visited.Contains(child.Value))
                    {
                        stack.Push(child.Value);
                    }
                }

                if (graph[currentNode].Count == 1) // Проверка дали сме достигнали листо.
                {
                    if (maxCount < currCount)
                    {
                        maxCount = currCount;
                    }

                    currCount = 0;
                }
            }


            return maxCount;
        }

        public static void ReadInput(int edges)
        {
            for (int i = 0; i < edges; i++)
            {
                int[] nodes = Console.ReadLine().Split()
                 .Select(int.Parse).ToArray();

                Tree<int> parentNode = new Tree<int>(nodes[0]);

                Tree<int> child = new Tree<int>(nodes[1]);

                if (!graph.ContainsKey(parentNode.Value))
                {
                    graph[parentNode.Value] = new List<Tree<int>>();
                }

                graph[parentNode.Value].Add(child);

                if (!graph.ContainsKey(child.Value))
                {
                    graph[child.Value] = new List<Tree<int>>();
                }

                graph[child.Value].Add(parentNode);
            }
        }
    }
}
