using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class CommissionReportMessage
    {
        public CommissionReportMessage(CommissionReport commissionReport)
        {
            CommissionReport = commissionReport;
        }

        public CommissionReport CommissionReport { get; }

        public override string ToString()
        {
            return $"{nameof(CommissionReport)}: {CommissionReport}";
        }
    }
}