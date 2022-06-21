using System;

namespace ChessmenCore
{
    public class King : Piece
    {
        public King(int x, int y, int color) : base(x, y, color)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            if (base.isRightTurn(x1, y1)) return (Math.Abs(x - x1) <= 1 && Math.Abs(y - y1) <= 1);
            return false;
        }
    }
}
