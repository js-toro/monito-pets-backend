using System.Net;

namespace MonitoPetsBackend.Infrastructure.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }


        public ValidationException(string message, HttpStatusCode code) : base(message)
        {
            StatusCode = code;
        }
    }
}
