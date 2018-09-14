namespace IB.CSharpApiClient.Messages
{
    public class TickGenericMessage : MarketDataMessage
    {
        public TickGenericMessage(int requestId, int field, double value) : base(requestId, field)
        {
            Value = value;
        }

        public double Value { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Value)}: {Value}";
        }
    }
}