using System;
using System.Runtime.Serialization;

namespace TestRockPaperScissors
{
    [Serializable]
    internal class ActException : Exception
    {
        public ActException()
        {
        }

        public ActException(string message) : base(message)
        {
        }

        public ActException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ActException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}