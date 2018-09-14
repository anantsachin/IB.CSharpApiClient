namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTickBidAskEndMessage
    {
        public HistoricalTickBidAskEndMessage(int reqId)
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