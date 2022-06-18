using System;

namespace ChessmenCore
{
    public abstract class Piece
    {
        protected int x;
        protected int y;

        public Arranger arranger;

        public Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Turn(int x1, int y1)
        {
            if (isRightTurn(x1, y1))
            {
                this.x = x1;
                this.y = y1;
                arranger.PlacePiece(x, y);
                return;
            }
            throw (new Exception("The piece cannot make such a move."));
        }

        public abstract bool isRightTurn(int x1, int y1);
        /*public virtual bool isRightTurn(int x1, int y1)
        {
            return false;
        }*/
    }
}
