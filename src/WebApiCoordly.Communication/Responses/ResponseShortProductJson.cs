namespace WebApiCoordly.Communication.Responses
{
    public class ResponseShortProductJson
    {
        public long ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
