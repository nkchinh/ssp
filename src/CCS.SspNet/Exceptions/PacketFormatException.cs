using System;

namespace CCS.SspNet.Exceptions
{
    public class PacketFormatException : Exception
    {
        public PacketFormatException()
        {
        }

        public PacketFormatException(string message) : base(message)
        {
        }

        public PacketFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
