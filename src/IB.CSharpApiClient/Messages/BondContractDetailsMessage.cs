using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class BondContractDetailsMessage
    {
        public BondContractDetailsMessage(int requestId, ContractDetails contractDetails)
        {
            RequestId = requestId;
            ContractDetails = contractDetails;
        }

        public int RequestId { get; }
        public ContractDetails ContractDetails { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(ContractDetails)}: {ContractDetails}";
        }
    }
}