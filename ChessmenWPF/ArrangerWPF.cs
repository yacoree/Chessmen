using ChessmenCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessmenWPF
{
    class ArrangerWPF : Arranger
    {
        public override void PlacePiece(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; i < 8; i++)
                {
                    Piece p = Piece.checkerboard[i, j];
                }
            }
        }
    }
}
