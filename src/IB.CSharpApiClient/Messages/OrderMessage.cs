namespace IB.CSharpApiClient.Messages
{
    public abstract class OrderMessage
    {
        protected OrderMessage(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; }

        public override string ToString()
        {
            return $"{nameof(OrderId)}: {OrderId}";
        }
    }
}