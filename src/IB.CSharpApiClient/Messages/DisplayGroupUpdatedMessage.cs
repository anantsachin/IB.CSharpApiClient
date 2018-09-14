namespace IB.CSharpApiClient.Messages
{
    public class DisplayGroupUpdatedMessage
    {
        public DisplayGroupUpdatedMessage(int reqId, string contractInfo)
        {
            ReqId = reqId;
            ContractInfo = contractInfo;
        }

        public int ReqId { get; }
        public string ContractInfo { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(ContractInfo)}: {ContractInfo}";
        }
    }
}