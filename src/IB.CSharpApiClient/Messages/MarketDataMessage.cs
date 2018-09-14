namespace IB.CSharpApiClient.Messages
{
    public abstract class MarketDataMessage
    {
        protected MarketDataMessage(int requestId, int field)
        {
            RequestId = requestId;
            Field = field;
        }

        public int RequestId { get; }
        public int Field { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Field)}: {Field}";
        }
    }
}