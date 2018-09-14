using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class DeltaNeutralValidationMessage
    {
        public DeltaNeutralValidationMessage(int reqId, UnderComp underComp)
        {
            ReqId = reqId;
            UnderComp = underComp;
        }

        public int ReqId { get; }
        public UnderComp UnderComp { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(UnderComp)}: {UnderComp}";
        }
    }
}