using System;

namespace Chessmen
{
    public class Rook : Piece
    {
        public Rook(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool isRightTurn(int x1, int y1)
        {
            return (x == x1 || y == y1);
        }

    }
}
