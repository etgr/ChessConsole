namespace ChessConsole.BoardLayer
{
    class Board
    {
        public int LineNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Piece[,] Pieces { get; set; }

        public Board()
        {
        }

        public Board(int lineNumber, int columnNumber)
        {
            LineNumber = lineNumber;
            ColumnNumber = columnNumber;
            Pieces = new Piece[LineNumber, ColumnNumber];
        }
    }
}
