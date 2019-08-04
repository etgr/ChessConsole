using ChessConsole.BoardLayer.Enums;

namespace ChessConsole.BoardLayer
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementCounter { get; protected set; }
        public Board Board { get; protected set; }

        public Piece()
        {
            MovementCounter = 0;
        }

        public Piece(Position position, Color color, Board board) : this()
        {
            Position = position;
            Color = color;
            Board = board;
        }
    }
}
