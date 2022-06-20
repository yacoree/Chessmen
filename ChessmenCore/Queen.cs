using System;

namespace ChessmenCore
{
    public class Queen : Piece
    {
        public Queen(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            if (base.isRightTurn(x1, y1)) 
                return (x == x1 || y == y1 ||
                     Math.Abs(x - x1) == Math.Abs(y - y1));
            return false;
        }
    }
}
