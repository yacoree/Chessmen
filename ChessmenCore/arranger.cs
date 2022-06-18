using System;
using System.Collections.Generic;

namespace Chessmen
{
    abstract public class Arranger
    {
        public abstract void PlacePiece(int x, int y);
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
