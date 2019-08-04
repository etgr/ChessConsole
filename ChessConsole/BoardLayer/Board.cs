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

        public Piece GetPiece (int line, int column)
        {
            return _pieces[line, column];
        }

        public void AddPiece (Piece piece, Position position)
        {
            _pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }
    }
}
