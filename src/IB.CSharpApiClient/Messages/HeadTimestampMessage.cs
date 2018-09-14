namespace IB.CSharpApiClient.Messages
{
    public class HeadTimestampMessage
    {
        public HeadTimestampMessage(int reqId, string headTimestamp)
        {
            ReqId = reqId;
            HeadTimestamp = headTimestamp;
        }

        public int ReqId { get; }
        public string HeadTimestamp { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(HeadTimestamp)}: {HeadTimestamp}";
        }
    }
}