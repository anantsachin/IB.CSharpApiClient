namespace IB.CSharpApiClient.Messages
{
    public class TickSizeMessage : MarketDataMessage
    {
        public TickSizeMessage(int requestId, int field, int size) 
            : base(requestId, field)
        {
            Size = size;
        }

        public int Size { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Size)}: {Size}";
        }
    }
}