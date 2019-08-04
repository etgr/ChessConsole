using System;
using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;
using ChessConsole.BoardLayer.Exceptions;
using ChessConsole.ChessGameLayer;


namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board b = new Board(8, 8);

                b.AddPiece(new Tower(Color.White, b), new Position(0, 0));
                b.AddPiece(new Tower(Color.Black, b), new Position(5, 7));
                b.AddPiece(new King(Color.Black, b), new Position(1, 2));

                ScreenOperation.PrintBoard(b);

                Console.WriteLine();
                ChessPosition p1 = new ChessPosition(1, 'a');
                Console.WriteLine(p1);
                Console.WriteLine(p1.ToPosition());
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message + "!");
            }
        }
    }
}
