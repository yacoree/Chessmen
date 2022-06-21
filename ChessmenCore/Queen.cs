using System;

namespace ChessmenCore
{
    public class Queen : Piece
    {
        public Queen(int x, int y, int color) : base(x, y, color)
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
                else if (Math.Abs(x - x1) == Math.Abs(y - y1))
                {
                    int minX;
                    int maxX;
                    int minY;
                    int maxY;
                    if (((x - x1 > 0) && (y - y1 > 0)) || ((x - x1 < 0) && (y - y1 < 0)))
                    {
                        minX = Math.Min(x, x1);
                        maxX = Math.Max(x, x1);
                        minY = Math.Min(y, y1);
                        maxY = Math.Max(y, y1);
                    }
                    else if ((x - x1 > 0) && (y - y1 < 0))
                    {
                        minX = x;
                        maxX = x1;
                        minY = y;
                        maxY = y1;
                    }
                    else
                    {
                        minX = x1;
                        maxX = x;
                        minY = y1;
                        maxY = y;
                    }
                    for (int Xcount = minX + 1, Ycount = minY + 1; Xcount < maxX || Ycount < maxY; Xcount++, Ycount++)
                    {
                        if (checkerboard[Xcount, Ycount] != null) return false;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
