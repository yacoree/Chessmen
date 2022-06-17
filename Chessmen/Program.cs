using System;

namespace Chessmen
{
    class Program
    {
        static void Main()
        {
            Piece king = new Queen(1,1);
            king.Turn(6, 6);
        }
    }
}