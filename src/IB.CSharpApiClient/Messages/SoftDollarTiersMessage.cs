using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class SoftDollarTiersMessage
    {
        public SoftDollarTiersMessage(int reqId, SoftDollarTier[] tiers)
        {
            ReqId = reqId;
            Tiers = tiers;
        }

        public int ReqId { get; }
        public SoftDollarTier[] Tiers { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Tiers)}: {Tiers}";
        }
    }
}