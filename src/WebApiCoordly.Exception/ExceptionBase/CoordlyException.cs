namespace WebApiCoordly.Exception.ExceptionBase
{
    public abstract class CoordlyException : SystemException
    {
        protected CoordlyException(string message) : base(message)
        {
            
        }

        public abstract int StatusCode { get; }
        public abstract List<string> GetErrors();
    }
}
