using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;

namespace ChessConsole.ChessGameLayer
{
    class Queen : Piece
    {
        public Queen(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
