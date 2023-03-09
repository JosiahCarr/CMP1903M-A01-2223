using System;
using System.Runtime.Serialization;

namespace CMP1903M_A01_2223
{
    [Serializable]
    internal class IndexOutOfRange : Exception
    {
        public IndexOutOfRange()
        {
        }

        public IndexOutOfRange(string message) : base(message)
        {
        }

        public IndexOutOfRange(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IndexOutOfRange(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}