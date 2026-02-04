namespace XtsClient.Models
{
    public class LoginRequest
    {
        public string apiKey { get; set; } = string.Empty;
        public string apiSecret { get; set; } = string.Empty;
        public string source { get; set; } = string.Empty;
    }
}