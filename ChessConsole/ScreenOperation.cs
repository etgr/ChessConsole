using System;
using System.Collections.Generic;
using System.Text;
using ChessConsole.BoardLayer;

namespace ChessConsole
{
    class ScreenOperation
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.LineNumber; i++)
            {
                for (int j = 0; j < board.ColumnNumber; j++)
                {
                    if (board.GetPiece(i, j) != null)
                    {
                        Console.Write(board.GetPiece(i,j) + " ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
