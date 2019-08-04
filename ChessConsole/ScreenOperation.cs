using System;
using System.Collections.Generic;
using System.Text;
using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;

namespace ChessConsole
{
    class ScreenOperation
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.LineNumber; i++)
            {
                Console.Write((8-i) + " ");
                for (int j = 0; j < board.ColumnNumber; j++)
                {
                    if (board.GetPiece(i, j) != null)
                    {
                        PrintPiece(board.GetPiece(i, j));                        
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");           
        }

        static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece + " ");
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece + " ");
                Console.ForegroundColor = aux;
            }
        }
    }
}
