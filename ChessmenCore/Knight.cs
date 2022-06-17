using System;

namespace Chessmen
{
    public class Knight : Piece
    {
        public Knight(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            return ((Math.Abs(x - x1) == 2 && Math.Abs(y - y1) == 1) ||
                    (Math.Abs(x - x1) == 1 && Math.Abs(y - y1) == 2));
        }
    }
}
