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
                    return this.CanMakeTurn(x1, y1);
                }
            }

            return false;
        }
    }
}
