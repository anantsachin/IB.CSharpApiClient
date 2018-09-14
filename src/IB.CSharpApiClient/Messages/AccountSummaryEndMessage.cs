namespace IB.CSharpApiClient.Messages
{
    public class AccountSummaryEndMessage
    {
        public AccountSummaryEndMessage(int requestId)
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