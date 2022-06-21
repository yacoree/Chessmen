using System;

namespace ChessmenCore
{
    public class Rook : Piece
    {
        public Rook(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            if (base.isRightTurn(x1, y1))
            {
                if (y == y1 || x == x1)
                {
                    if (y == y1)
                    {
                        int minX = Math.Min(x, x1);
                        int maxX = Math.Max(x, x1);
                        for (int i = minX + 1; i < maxX; i++)
                        {
                            if (checkerboard[i, y] != null) return false;
                        }
                    }
                    if (x == x1)
                    {
                        int minY = Math.Min(y, y1);
                        int maxY = Math.Max(y, y1);
                        for (int i = minY + 1; i < maxY; i++)
                        {
                            if (checkerboard[x, i] != null) return false;
                        }
                    }
                    return true;
                }
            }

            return false;
        }
    }
}
