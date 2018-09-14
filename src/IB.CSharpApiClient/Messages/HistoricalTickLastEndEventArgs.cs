using System;

namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTickLastEndEventArgs : EventArgs
    {
        public HistoricalTickLastEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }

        public int ReqId { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}