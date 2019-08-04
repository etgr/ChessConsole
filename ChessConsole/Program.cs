using System;
using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;
using ChessConsole.ChessGameLayer;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(8, 8);

            b.AddPiece(new Tower(Color.White, b), new Position(0, 0));
            b.AddPiece(new Tower(Color.White, b), new Position(5, 7));
            b.AddPiece(new King(Color.Black, b), new Position(1, 2));

            ScreenOperation.PrintBoard(b);
        }
    }
}
