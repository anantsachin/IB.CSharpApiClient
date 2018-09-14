namespace IB.CSharpApiClient.Messages
{
    public class MarketDataTypeMessage
    {
        public MarketDataTypeMessage(int requestId, int marketDataType)
        {
            RequestId = requestId;
            MarketDataType = marketDataType;
        }

        public int RequestId { get; }
        public int MarketDataType { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(MarketDataType)}: {MarketDataType}";
        }
    }
}