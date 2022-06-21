using System;

namespace ChessmenCore
{
    public class Bishop : Piece
    {
        public Bishop(int x, int y, int color) : base(x, y, color)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            if (base.isRightTurn(x1, y1))
            {
                if (Math.Abs(x - x1) == Math.Abs(y - y1))
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
