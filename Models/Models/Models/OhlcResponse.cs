namespace XtsClient.Models
{
    public class OhlcResponse
    {
        public string Status { get; set; } = string.Empty;
        public object Data { get; set; } = new();
    }
}