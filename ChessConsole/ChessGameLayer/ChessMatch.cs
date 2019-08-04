using System;
using System.Collections.Generic;
using System.Text;
using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;

namespace ChessConsole.ChessGameLayer
{
    class ChessMatch
    {
        public Board Board { get; private set; }
        public Color CurrentPlayer { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            CurrentPlayer = Color.White;
            InitializeBoardPieces();
        }

        public void MovePiece(Position start, Position destination)
        {
            Piece piece = Board.RemovePiece(start);
            piece.IncreaseMovementCounter();
            Piece capturedPiece = Board.RemovePiece(destination);
            Board.AddPiece(piece, destination);
        }

        private void InitializeBoardPieces()
        {
            // White pieces
            Board.AddPiece(new Tower(Color.White, Board), new ChessPosition('c', 1).ToPosition());
            Board.AddPiece(new King(Color.White, Board), new ChessPosition('d', 1).ToPosition());
            Board.AddPiece(new Tower(Color.White, Board), new ChessPosition('e', 1).ToPosition());

            // Black pieces
            Board.AddPiece(new Tower(Color.Black, Board), new ChessPosition('c', 8).ToPosition());
            Board.AddPiece(new King(Color.Black, Board), new ChessPosition('d', 8).ToPosition());
            Board.AddPiece(new Tower(Color.Black, Board), new ChessPosition('e', 8).ToPosition());
        }
    }
}
