using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistogramDataMessage
    {
        public HistogramDataMessage(int reqId, HistogramEntry[] data)
        {
            ReqId = reqId;
            Data = data;
        }

        public int ReqId { get; }
        public HistogramEntry[] Data { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Data)}: {Data}";
        }
    }
}