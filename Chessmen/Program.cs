using ChessmenCore;
using System;

namespace ChessmenConsole
{
    class Program
    {
        static void Main()
        {
            string chess;
            while ((chess = Console.ReadLine()) != "stop")
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Piece f = PieceMaker.Make(chess, x1, y1);
                    f.arranger = new ArrangerConsole();
                    f.Turn(x2, y2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}