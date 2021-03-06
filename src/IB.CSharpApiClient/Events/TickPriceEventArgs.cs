﻿using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class TickPriceEventArgs : MarketDataEventArgs
    {
        public TickPriceEventArgs(int requestId, int field, double price, TickAttrib attribs)
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