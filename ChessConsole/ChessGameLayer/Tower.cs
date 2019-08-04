using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;

namespace ChessConsole.ChessGameLayer
{
    class Tower : Piece
    {
        public Tower(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
