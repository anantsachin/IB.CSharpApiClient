namespace IB.CSharpApiClient.Messages
{
    public class TickSnapshotEndMessage
    {
        public TickSnapshotEndMessage(int requestId)
        {
            RequestId = requestId;
        }

        public int RequestId { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}