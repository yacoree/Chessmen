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
                if (y == y1 || x == x1 || (Math.Abs(x - x1) == Math.Abs(y - y1)))
                {
                    return base.CanMakeTurn(x1, y1);
                }
            }
            return false;
        }
    }
}
