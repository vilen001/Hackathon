using System.Runtime.Serialization;

namespace FieryRestaurent.ServiceLayer.SupplierService
{
    [Serializable]
    public class InvalidLicenseException : Exception
    {
        public InvalidLicenseException()
        {
        }

        public InvalidLicenseException(string? message) : base(message)
        {
        }

        public InvalidLicenseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidLicenseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}