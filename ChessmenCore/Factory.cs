using System;
using System.Collections.Generic;

namespace ChessmenCore
{
    public enum ChessPieces
    {
        King,
        Queen,
        Bishop,
        Knight,
        Rook,
        Pawn
    }

    public static class PieceMaker
    {
        private static readonly Dictionary<string, ChessPieces> ChessPiecesCode;

        static PieceMaker()
        {
            ChessPiecesCode = new Dictionary<string, ChessPieces>()
            {
                { "King",  ChessPieces.King},
                { "K",  ChessPieces.King},
                { "Queen",  ChessPieces.Queen},
                { "Q",  ChessPieces.Queen},
                { "Bishop",  ChessPieces.Bishop},
                { "B",  ChessPieces.Bishop},
                { "Knight",  ChessPieces.Knight},
                { "N",  ChessPieces.Knight},
                { "Rook",  ChessPieces.Rook},
                { "R",  ChessPieces.Rook},
            };
        }

        static public Piece Make(ChessPieces pieceCode, int x, int y, int color)
        {
            Piece piece = null;

            switch (pieceCode)
            {
                case ChessPieces.King:
                    piece = new King(x, y, color);
                    break;
                case ChessPieces.Queen:
                    piece = new Queen(x, y, color);
                    break;
                case ChessPieces.Bishop:
                    piece = new Bishop(x, y, color);
                    break;
                case ChessPieces.Knight:
                    piece = new Knight(x, y, color);
                    break;
                case ChessPieces.Rook:
                    piece = new Rook(x, y, color);
                    break;

                default:
                    throw new Exception("Unknown piece code");
            }

            return piece;
        }

        static public Piece Make(string pieceCode, int x, int y, int color)
        {
            return Make(ChessPiecesCode[pieceCode], x, y, color);
        }
    }
}