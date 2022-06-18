using ChessmenCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessmenConsole
{
    class ArrangerConsole : Arranger
    {
        public override void PlacePiece(int x, int y)
        {
            Console.WriteLine($"Новые координаты фигуры {x}:{y}");
        }
    }
}
