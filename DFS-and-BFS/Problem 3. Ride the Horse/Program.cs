namespace Problem_3.Ride_the_Horse
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static int[,] Matrix;
        private static int[] rowMoves = { -2, -1, 1, 2, 2, 1, -1, -2 };
        private static int[] colMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };
        private static int Rows;
        private static int Cols;

        static void Main()
        {
            Rows = int.Parse(Console.ReadLine());
            Cols = int.Parse(Console.ReadLine());
            Matrix = new int[Rows, Cols];
            int startRow = int.Parse(Console.ReadLine());
            int startCol = int.Parse(Console.ReadLine());
            Tuple<int, int> startPoint = new Tuple<int, int>(startRow, startCol);
            BFS(startPoint);
            Console.WriteLine();
            for (int r = 0; r < Rows; r++)
            {
                Console.WriteLine(Matrix[r, Cols / 2]);
            }
        }

        private static void BFS(Tuple<int, int> point)
        {
            var queue = new Queue<Tuple<int, int>>();
            var visited = new HashSet<Tuple<int, int>>();

            queue.Enqueue(point);
            int startRow = point.Item1;
            int startCol = point.Item2;
            Matrix[startRow, startCol] = 1;

            while (queue.Count > 0)
            {
                Tuple<int, int> currPoint = queue.Dequeue();
                int currRow = currPoint.Item1;
                int currCol = currPoint.Item2;
                visited.Add(currPoint);

                for (int i = 0; i < rowMoves.Length; i++)
                {
                    int newRow = currPoint.Item1 + rowMoves[i];
                    int newCol = currPoint.Item2 + colMoves[i];
                    Tuple<int, int> newPoint = new Tuple<int, int>(newRow, newCol);
                    if (newRow >= 0 && newRow < Rows && newCol >= 0 && newCol < Cols &&
                        !visited.Contains(newPoint))
                    {
                        queue.Enqueue(newPoint);
                        Matrix[newRow, newCol] = Matrix[currRow, currCol] + 1;
                    }
                }
            }
        }
    }
}
