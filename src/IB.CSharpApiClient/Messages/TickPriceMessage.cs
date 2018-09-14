using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class TickPriceMessage : MarketDataMessage
    {
        public TickPriceMessage(int requestId, int field, double price, TickAttrib attribs)
            : base(requestId, field)
        {
            Price = price;
            Attribs = attribs;
        }

        public double Price { get; }

        public TickAttrib Attribs { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Attribs)}: {Attribs}, {nameof(Price)}: {Price}";
        }
    }
}