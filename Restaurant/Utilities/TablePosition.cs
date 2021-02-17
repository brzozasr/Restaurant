using System;

namespace Restaurant.Utilities
{
    public struct TablePosition
    {
        public int X { get; }
        public int Y { get; }
        
        public TablePosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is TablePosition position)
            {
                return this.X == position.X && this.Y == position.Y;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}