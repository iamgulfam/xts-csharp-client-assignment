namespace XtsClient.Models
{
    public class OhlcRequest
    {
        public string ExchangeSegment { get; set; } = "NSECM";
        public int InstrumentId { get; set; }
        public string Interval { get; set; } = "1minute";
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}