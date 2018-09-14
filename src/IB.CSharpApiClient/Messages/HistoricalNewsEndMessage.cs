namespace IB.CSharpApiClient.Messages
{
    public class HistoricalNewsEndMessage
    {
        public HistoricalNewsEndMessage(int requestId, bool hasMore)
        {
            RequestId = requestId;
            HasMore = hasMore;
        }

        public int RequestId { get; }
        public bool HasMore { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(HasMore)}: {HasMore}";
        }
    }
}