namespace IB.CSharpApiClient.Messages
{
    public class AccountUpdateMultiEndMessage
    {
        public AccountUpdateMultiEndMessage(int reqId)
        {
            ReqId = ReqId;
        }

        public int ReqId { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}