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
                ChessMatch match = new ChessMatch();

                bool continueMatch = true;
                while (continueMatch)
                {
                    ScreenOperation.PrintBoard(match.Board);
                    Console.WriteLine();
                    Console.WriteLine("Enter origin position: ");
                    string posStart = Console.ReadLine();
                    Console.WriteLine("Enter destination position: ");
                    string posDest = Console.ReadLine();
                    match.MovePiece(new ChessPosition(posStart[0], int.Parse(posStart.Substring(1))).ToPosition(), 
                        new ChessPosition(posDest[0], int.Parse(posDest.Substring(1))).ToPosition());

                    Console.WriteLine("Continue? ");
                    continueMatch = bool.Parse(Console.ReadLine());
                    Console.Clear();
                }

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message + "!");
            }
        }
    }
}
