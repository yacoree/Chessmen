using System;

namespace ChessmenCore
{
    public class Rook : Piece
    {
        public Rook(int x, int y, int color) : base(x, y, color)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            if (base.isRightTurn(x1, y1))
            {
                if (y == y1 || x == x1)
                {
                    return base.CanMakeTurn(x1, y1);
                }
            }

            return false;
        }
    }
}
