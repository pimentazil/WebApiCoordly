namespace WebApiCoordly.Communication.Requests
{
    public class RequestRegisterProductJson
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
