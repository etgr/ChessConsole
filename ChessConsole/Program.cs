using System;
using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p1 = new Position(2, 3);
            Board b1 = new Board(8, 8);
            Piece pc1 = new Piece(p1, Enum.Parse<Color>("Black"), b1);
            Console.WriteLine(p1);
            Console.WriteLine(pc1.Color);
            Console.WriteLine(pc1.Position);
        }
    }
}
