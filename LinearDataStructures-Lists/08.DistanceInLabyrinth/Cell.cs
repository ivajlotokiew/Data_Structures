namespace _08.DistanceInLabyrinth
{
    public class Cell
    {
        public Cell(int x, int y, int index)
        {
            this.X = x;
            this.Y = y;
            this.Index = index;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public int Index { get; private set; }
    }
}