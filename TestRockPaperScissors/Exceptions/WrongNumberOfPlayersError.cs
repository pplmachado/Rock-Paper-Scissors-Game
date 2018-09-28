using System;
using System.Runtime.Serialization;

namespace TestRockPaperScissors
{
    [Serializable]
    internal class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError()
        {
        }

        public WrongNumberOfPlayersError(string message) : base(message)
        {
        }

        public WrongNumberOfPlayersError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongNumberOfPlayersError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}