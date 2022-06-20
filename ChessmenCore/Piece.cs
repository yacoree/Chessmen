using System;

namespace ChessmenCore
{
    public abstract class Piece
    {
        public static int checkerboardWidth = 8;
        public static int checkerboardHeight = 8;
        public static Piece[,] checkerboard = new Piece[checkerboardWidth, checkerboardHeight];

        protected int x;
        protected int y;

        public Arranger arranger;

        public Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
            checkerboard[x, y] = this;
        }

        public void Turn(int x1, int y1)
        {
            if (isRightTurn(x1, y1))
            {
                checkerboard[x, y] = null;
                this.x = x1;
                this.y = y1;
                checkerboard[x, y] = this;
                arranger.PlacePiece(x, y);
                return;
            }
            throw new Exception("The piece cannot make such a move.");
        }

        public (int x, int y) Parse()
        {
            return (x, y);
        }

        //public abstract bool isRightTurn(int x1, int y1);
        public virtual bool isRightTurn(int x1, int y1)
        {
            bool res = false;
            if ((x1 < checkerboardWidth && x1 > 0) && (y1 < checkerboardHeight && y1 > 0)) 
            {
                if (checkerboard[x1, y1] == null) res = true;
            }
            return res;
        }
    }
}
