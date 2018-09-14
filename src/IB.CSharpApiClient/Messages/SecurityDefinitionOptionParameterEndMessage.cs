namespace IB.CSharpApiClient.Messages
{
    public class SecurityDefinitionOptionParameterEndMessage
    {
        public SecurityDefinitionOptionParameterEndMessage(int reqId)
        {
            RequestId = reqId;
        }

        public int RequestId { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}