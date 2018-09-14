namespace IB.CSharpApiClient.Messages
{
    public class ScannerEndMessage
    {
        public ScannerEndMessage(int requestId)
        {
            RequestId = requestId;
        }

        public int RequestId { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}