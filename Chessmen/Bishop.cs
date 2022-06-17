using System;

namespace Chessmen
{
    public class Bishop : Piece
    {
        public Bishop(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            return (Math.Abs(x - x1) == Math.Abs(y - y1));
        }
    }
}
