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
        }

        public Piece(Color color, Board board)
        {
            Color = color;
            Board = board;
        }

        public void IncreaseMovementCounter()
        {
            MovementCounter++;
        }
    }
}
