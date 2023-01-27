using System.Runtime.Serialization;

namespace FieryRestaurent.Exceptions.CustomExceptions
{
    [Serializable]
    public class LicienseExpiredException : Exception
    {
        public LicienseExpiredException()
        {
        }

        public LicienseExpiredException(string? message) : base(message)
        {
        }

        public LicienseExpiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LicienseExpiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}