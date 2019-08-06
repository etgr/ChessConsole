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
            Board.AddPiece(new Tower(Color.White, Board), new ChessPosition('a', 1).ToPosition());
            Board.AddPiece(new Knight(Color.White, Board), new ChessPosition('b', 1).ToPosition());
            Board.AddPiece(new Bishop(Color.White, Board), new ChessPosition('c', 1).ToPosition());
            Board.AddPiece(new Queen(Color.White, Board), new ChessPosition('d', 1).ToPosition());
            Board.AddPiece(new King(Color.White, Board), new ChessPosition('e', 1).ToPosition());
            Board.AddPiece(new Bishop(Color.White, Board), new ChessPosition('f', 1).ToPosition());
            Board.AddPiece(new Knight(Color.White, Board), new ChessPosition('g', 1).ToPosition());
            Board.AddPiece(new Tower(Color.White, Board), new ChessPosition('h', 1).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('a', 2).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('b', 2).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('c', 2).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('d', 2).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('e', 2).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('f', 2).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('g', 2).ToPosition());
            Board.AddPiece(new Pawn(Color.White, Board), new ChessPosition('h', 2).ToPosition());

            // Black pieces
            Board.AddPiece(new Tower(Color.Black, Board), new ChessPosition('a', 8).ToPosition());
            Board.AddPiece(new Knight(Color.Black, Board), new ChessPosition('b', 8).ToPosition());
            Board.AddPiece(new Bishop(Color.Black, Board), new ChessPosition('c', 8).ToPosition());
            Board.AddPiece(new Queen(Color.Black, Board), new ChessPosition('d', 8).ToPosition());
            Board.AddPiece(new King(Color.Black, Board), new ChessPosition('e', 8).ToPosition());
            Board.AddPiece(new Bishop(Color.Black, Board), new ChessPosition('f', 8).ToPosition());
            Board.AddPiece(new Knight(Color.Black, Board), new ChessPosition('g', 8).ToPosition());
            Board.AddPiece(new Tower(Color.Black, Board), new ChessPosition('h', 8).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('a', 7).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('b', 7).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('c', 7).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('d', 7).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('e', 7).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('f', 7).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('g', 7).ToPosition());
            Board.AddPiece(new Pawn(Color.Black, Board), new ChessPosition('h', 7).ToPosition());
        }
    }
}
