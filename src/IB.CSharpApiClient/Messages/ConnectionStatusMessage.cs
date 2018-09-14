namespace IB.CSharpApiClient.Messages
{
    public class ConnectionStatusMessage
    {
        public ConnectionStatusMessage(bool isConnected, int orderId)
        {
            IsConnected = isConnected;
            NextValidOrderId = orderId;
        }

        public bool IsConnected { get; }
        public int NextValidOrderId { get; }

        public override string ToString()
        {
            return $"{nameof(IsConnected)}: {IsConnected}, {nameof(NextValidOrderId)}: {NextValidOrderId}";
        }
    }
}