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
                    chessmen = new Rook(chessmenData.Data["X"], chessmenData.Data["Y"]);
                    break;
            }
            return chessmen;
        }

        /*public static List<FiguresData> InitFiguresData()
        {
            var figuresData = new List<FiguresData>();

            figuresData.Add(new FiguresData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 },
                    { "Radius", 100 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Line",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 100 },
                    { "Y2", 100 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Rectangle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Height", 100 },
                    { "Weight", 100 }
                }
            });

            return figuresData;
        }*/
    }
}
