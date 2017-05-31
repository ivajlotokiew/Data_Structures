namespace _08.DistanceInLabyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class DistanceInLabyrinth
    {
        private const string StartMark = "*";
        private const string EmptyCell = "0";

        private static string[,] maze;
        private static int mazeSize;

        public static void Main()
        {
            // Sameple input:
            //
            // 6
            // 0 0 0 x 0 x
            // 0 x 0 x 0 x
            // 0 * x 0 x 0
            // 0 x 0 0 0 0
            // 0 0 0 x x 0
            // 0 0 0 x 0 x

            Console.Write("Maze size = ");
            mazeSize = int.Parse(Console.ReadLine());

            maze = new string[mazeSize, mazeSize];
            FillMaze(mazeSize, maze);

            var startCell = FindStartCell();
            if (startCell == null)
            {
                Console.WriteLine("There's no entry point in the maze!");
                return;
            }

            var queue = new Queue<Cell>();
            queue.Enqueue(startCell);
            TraverseLabyrinthBfs(queue);

            PrintMaze();
        }

        private static void PrintMaze()
        {
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    Console.Write($"{maze[row, col],-2}");
                }

                Console.WriteLine();
            }
        }

        private static Cell FindStartCell()
        {
            for (int row = 0; row < mazeSize; row++)
            {
                for (int col = 0; col < mazeSize; col++)
                {
                    if (maze[row, col] == StartMark)
                    {
                        return new Cell(row, col, 0);
                    }
                }
            }

            return null;
        }

        private static void TraverseLabyrinthBfs(Queue<Cell> queue)
        {
            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();

                if (maze[currentCell.X, currentCell.Y] != StartMark)
                {
                    maze[currentCell.X, currentCell.Y] = currentCell.Index.ToString();
                }

                TryCell(queue, currentCell, 0, -1);
                TryCell(queue, currentCell, 1, 0);
                TryCell(queue, currentCell, 0, 1);
                TryCell(queue, currentCell, -1, 0);
            }
        }

        private static void TryCell(
            Queue<Cell> queue, 
            Cell currentCell, 
            int deltaX, 
            int deltaY)
        {
            var newX = currentCell.X + deltaX;
            var newY = currentCell.Y - deltaY;

            var inMaze = newX >= 0 && newX < mazeSize &&
                          newY >= 0 && newY < mazeSize;

            if (inMaze && maze[newX, newY] == EmptyCell)
            {
                queue.Enqueue(new Cell(newX, newY, currentCell.Index + 1));
            }
        }

        private static void FillMaze(int mazeSize, string[,] maze)
        {
            Console.WriteLine("Insert every row of the maze on a single line:");
            for (int row = 0; row < mazeSize; row++)
            {
                var inputRow = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < mazeSize; col++)
                {
                    maze[row, col] = inputRow[col].ToString();
                }
            }
        }
    }
}

// Hardcoded DEBUG maze
//            maze = new [,]
//            {
//                {"0", "0", "0", "x", "0", "x"},
//                {"0", "x", "0", "x", "0", "x"},
//                {"0", "*", "x", "0", "x", "0"},
//                {"0", "x", "0", "0", "0", "0"},
//                {"0", "0", "0", "x", "x", "0"},
//                {"0", "0", "0", "x", "0", "x"}
//            };