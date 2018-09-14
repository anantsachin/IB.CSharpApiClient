using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class MktDepthExchangesMessage
    {
        public MktDepthExchangesMessage(DepthMktDataDescription[] descriptions)
        {
            Descriptions = descriptions;
        }

        public DepthMktDataDescription[] Descriptions { get; }

        public override string ToString()
        {
            return $"{nameof(Descriptions)}: {Descriptions}";
        }
    }
}