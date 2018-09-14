namespace IB.CSharpApiClient.Messages
{
    public class DailyPnLMessage
    {
        public DailyPnLMessage(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            ReqId = reqId;
            DailyPnL = dailyPnL;
            UnrealizedPnL = unrealizedPnL;
            RealizedPnL = realizedPnL;
        }

        public int ReqId { get; }
        public double DailyPnL { get; }
        public double UnrealizedPnL { get; }
        public double RealizedPnL { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(DailyPnL)}: {DailyPnL}, {nameof(UnrealizedPnL)}: {UnrealizedPnL}, {nameof(RealizedPnL)}: {RealizedPnL}";
        }
    }
}