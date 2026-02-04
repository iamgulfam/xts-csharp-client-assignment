namespace XtsClient.Models
{
    public class FuturesOhlcRequest
    {
        public string ExchangeSegment { get; set; } = "NSEFO";
        public string Symbol { get; set; } = "NIFTY";
        public string Expiry { get; set; } = "NEAR_MONTH";
        public string Interval { get; set; } = "1_MIN";
    }
}