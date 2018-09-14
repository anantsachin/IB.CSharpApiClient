using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class OpenOrderMessage : OrderMessage
    {
        public OpenOrderMessage(int orderId, Contract contract, Order order, OrderState orderState) :
            base(orderId)
        {
            Contract = contract;
            Order = order;
            OrderState = orderState;
        }

        public Contract Contract { get; }

        public Order Order { get; }

        public OrderState OrderState { get; }

        public override string ToString()
        {
            return $"{nameof(Contract)}: {Contract}, {nameof(Order)}: {Order}, {nameof(OrderState)}: {OrderState}";
        }
    }
}