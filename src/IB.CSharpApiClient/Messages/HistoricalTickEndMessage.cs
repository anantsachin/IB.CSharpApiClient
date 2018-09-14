namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTickEndMessage
    {
        public HistoricalTickEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public int ReqId { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}