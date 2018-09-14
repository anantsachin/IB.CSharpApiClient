namespace IB.CSharpApiClient.Messages
{
    public class TickStringMessage : MarketDataMessage
    {
        public TickStringMessage(int requestId, int field, string value) : base(requestId, field)
        {
            Value = value;
        }

        public string Value { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Value)}: {Value}";
        }
    }
}