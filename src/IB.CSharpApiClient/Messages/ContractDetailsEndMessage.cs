namespace IB.CSharpApiClient.Messages
{
    public class ContractDetailsEndMessage
    {
        public ContractDetailsEndMessage(int requestId)
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