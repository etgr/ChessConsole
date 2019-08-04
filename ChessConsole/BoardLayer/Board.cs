using ChessConsole.BoardLayer.Exceptions;

namespace ChessConsole.BoardLayer
{
    class Board
    {
        private Piece[,] _pieces;
        public int LineNumber { get; set; }
        public int ColumnNumber { get; set; }

        public Board()
        {
        }

        public Board(int lineNumber, int columnNumber)
        {
            LineNumber = lineNumber;
            ColumnNumber = columnNumber;
            _pieces = new Piece[LineNumber, ColumnNumber];
        }

        public Piece GetPiece(int line, int column)
        {
            return _pieces[line, column];
        }

        public Piece GetPiece(Position position)
        {
            return _pieces[position.Line, position.Column];
        }

        public void AddPiece(Piece piece, Position position)
        {
            if (HasPieceOnPosition(position))
            {
                throw new BoardException("There is already a piece on this position");
            }
            _pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (!HasPieceOnPosition(position))
            {
                return null;
            }
            Piece removedPiece = GetPiece(position);
            removedPiece.Position = null;
            _pieces[position.Line, position.Column] = null;
            return removedPiece;
        }

        public bool HasPieceOnPosition(Position position)
        {
            ValidatePosition(position);
            return GetPiece(position) != null;
        }

        public bool IsValidPosition(Position position)
        {
            if (position.Line < 0 || position.Column < 0 || position.Line >= LineNumber || position.Column == ColumnNumber)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!IsValidPosition(position))
            {
                throw new BoardException("Invalid position");
            }
        }
    }
}
