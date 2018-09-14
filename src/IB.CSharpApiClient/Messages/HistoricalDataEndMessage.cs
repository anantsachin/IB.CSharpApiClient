namespace IB.CSharpApiClient.Messages
{
    public class HistoricalDataEndMessage
    {
        public HistoricalDataEndMessage(int requestId, string startDate, string endDate)
        {
            RequestId = requestId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int RequestId { get; }
        public string StartDate { get; }
        public string EndDate { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(StartDate)}: {StartDate}, {nameof(EndDate)}: {EndDate}";
        }
    }
}