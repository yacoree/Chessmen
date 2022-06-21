using System;

namespace ChessmenCore
{
    public abstract class Piece
    {
        private static int checkerboardWidth = 8;
        private static int checkerboardHeight = 8;
        public static Piece[,] checkerboard = new Piece[checkerboardWidth, checkerboardHeight];

        protected int x;
        protected int y;

        public int Color;

        public Arranger arranger;

        public Piece(int x, int y, int color)
        {
            this.x = x;
            this.y = y;
            this.Color = color;
            checkerboard[x, y] = this;
        }

        public void Turn(int x1, int y1)
        {
            if (isRightTurn(x1, y1))
            {
                if (checkerboard[x1, y1] != null) this.Capture(checkerboard[x1, y1]);
                this.Delete();
                this.x = x1;
                this.y = y1;
                checkerboard[x, y] = this;
                arranger.PlacePiece(x, y);
                return;
            }
            throw new Exception("The piece cannot make such a move.");
        }

        public void Capture(Piece piece)
        {
            if (this.Color != piece.Color) piece.Delete();
            throw new Exception("The piece cannot make such a move.");
        }

        public (int x, int y) Parse()
        {
            return (x, y);
        }

        public void Delete()
        {
            checkerboard[x, y] = null;
        }

        public virtual bool isRightTurn(int x1, int y1)
        {
            return (x1 < checkerboardWidth && x1 >= 0 && y1 < checkerboardHeight && y1 >= 0);
        }

        protected bool CanMakeTurn(int x1, int y1)
        {
            int count;
            if (y == y1) count = Math.Abs(x - x1);
            else count = Math.Abs(y - y1);
            int razX = (x - x1) / count;
            int razY = (y - y1) / count;
            int Xcount = x;
            int Ycount = y;
            while ((count - 1) != 0)
            {
                Xcount -= razX;
                Ycount -= razY;
                if (checkerboard[Xcount, Ycount] != null) return false;
                count--;
            }
            return true;
        }
    }
}
