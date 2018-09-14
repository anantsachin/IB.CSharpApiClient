namespace IB.CSharpApiClient.Messages
{
    public class ExecutionEndMessage
    {
        public ExecutionEndMessage(int requestId)
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