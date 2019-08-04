using System;

namespace ChessConsole.BoardLayer.Exceptions
{
    class BoardException : Exception
    {
        public BoardException(string message) : base(message)
        {
        }
    }
}
