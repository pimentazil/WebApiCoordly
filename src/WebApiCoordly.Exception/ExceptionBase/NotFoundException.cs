using System.Net;

namespace WebApiCoordly.Exception.ExceptionBase
{
    public class NotFoundException : CoordlyException
    {
        public NotFoundException(string message) : base(message)
        {
        }

        public override int StatusCode => (int)HttpStatusCode.NotFound;

        public override List<string> GetErrors()
        {
            return [Message];
        }
    }
}
