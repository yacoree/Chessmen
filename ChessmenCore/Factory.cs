using System;
using System.Collections.Generic;

namespace Chessmen
{
    public class ChessmenData
    {
        public string Name;
        public Dictionary<string, int> Data;

        public override string ToString()
        {
            return Name;
        }
    }

    static public class ChessmenFactory
    {
        public static Piece Make(ChessmenData chessmenData)
        {
            Piece chessmen = null;
            //int color = chessmenData.Data["Color"];
            switch (chessmenData.Name)
            {
                case "King":
                    chessmen = new King(chessmenData.Data["X"], chessmenData.Data["Y"]);
                    break;
                case "Knight":
                    chessmen = new Knight(chessmenData.Data["X"], chessmenData.Data["Y"]);
                    break;
                case "Queen":
                    chessmen = new Queen(chessmenData.Data["X"], chessmenData.Data["Y"]);
                    break;
                case "Rook":
                    chessmen = new Rook(chessmenData.Data["X"], chessmenData.   Data["Y"]);
                    break;
            }
            return chessmen;
        }
    }
}
