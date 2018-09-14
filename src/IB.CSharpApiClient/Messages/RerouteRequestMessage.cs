namespace IB.CSharpApiClient.Messages
{
    public class RerouteRequestMessage

    {
        public RerouteRequestMessage(int requestId, int conditionId, string exchange)
        {
            RequestId = requestId;
            ConditionId = conditionId;
            Exchange = exchange;
        }

        public int RequestId { get; }
        public int ConditionId { get; }
        public string Exchange { get; }

        public override string ToString()
        {
            return $"{nameof(ConditionId)}: {ConditionId}, {nameof(Exchange)}: {Exchange}, {nameof(RequestId)}: {RequestId}";
        }
    }
}